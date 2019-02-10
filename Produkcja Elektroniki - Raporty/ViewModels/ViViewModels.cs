using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MST.MES;
using Produkcja_Elektroniki___Raporty.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Produkcja_Elektroniki___Raporty.ViewModels
{
    public class ViViewModels
    {
        public LiveCharts.WinForms.CartesianChart PoziomOdpaduChart { get; }

        public ViViewModels(LiveCharts.WinForms.CartesianChart poziomOdpaduChart)
        {
            PoziomOdpaduChart = poziomOdpaduChart;
        }

        public class LastNgViewColumns
        {
            public DateTime Date;
            public string OrderNo;
            public string ModelId;
            public string ModelName;
            public string NgCount;
            public string ScrapCount;
        }

        public static List<LastNgViewColumns> LastNgSource()
        {
            List<LastNgViewColumns> result = new List<LastNgViewColumns>();
            var lastNgListOfOrders = DataContainer.sqlDataByOrder.SelectMany(o => o.Value.visualInspection.ngScrapList).OrderByDescending(ng => ng.ngRegistrationDate).Select(o => o.orderNo).Distinct().ToList(); //SqlDataByProcess.VisualInspection.SelectMany(o => o.Value.ngScrapList).OrderByDescending(d => d.ngRegistrationDate).Select(o=>o.orderNo).Distinct().Take(500).ToList();

            foreach (var order in lastNgListOfOrders)
            {
                var viOrder = DataContainer.sqlDataByOrder[order].visualInspection;
                LastNgViewColumns newItem = new LastNgViewColumns();
                newItem.Date = viOrder.ngScrapList.OrderByDescending(d => d.ngRegistrationDate).Select(d => d.ngRegistrationDate).First();
                newItem.NgCount = viOrder.ngCount.ToString();
                newItem.OrderNo = viOrder.orderNo;
                newItem.ScrapCount = viOrder.scrapCount.ToString();
                newItem.ModelId = DataContainer.sqlDataByOrder[order].kitting.modelId;
                string modelName = "";
                if (DataContainer.nc12ToName.ContainsKey(newItem.ModelId+"00"))
                {
                    modelName= DataContainer.nc12ToName[newItem.ModelId + "00"]; ;
                }
                else
                {
                    modelName = newItem.ModelId;
                }
                newItem.ModelName = modelName;
                result.Add(newItem);
            }


            return result;
        }

        private static string GetDateKey(string guiTimeInterval, DateTime date)
        {
            string result = "";
            switch (guiTimeInterval)
            {
                case "Dziennie":
                    {
                        result = date.ToString("dd-MMM");
                        break;
                    }
                case "Tygodniowo":
                    {
                        result = DateTools.GetWeekNoOfYear(date).ToString();
                        break;
                    }

                case "Miesiecznie":
                    {
                        result = date.ToString("MMM");
                        break;
                    }
            }
            return result;
        }

        private class WastePerPointStruct
        {
            public int totalProduction=0;
            public int totalNg=0;
            public int totalScrap=0;
        }

        public static void DrawPoziomOdpaduChart()
        {
            if (DataContainer.guiState == null) return;
            

            LiveCharts.WinForms.CartesianChart poziomOdpaduChart = DataContainer.poziomOdpaduChart;

            poziomOdpaduChart.Series.Clear();
            poziomOdpaduChart.AxisX.Clear();
            poziomOdpaduChart.AxisY.Clear();

            var finishedOrders = DataContainer.sqlDataByOrder.Where(order => order.Value.kitting.endDate >= DataContainer.guiState.viTabs.poziomOdpaduTab.startDate &&
                                                               order.Value.kitting.endDate <= DataContainer.guiState.viTabs.poziomOdpaduTab.endDate);
            if (!DataContainer.guiState.viTabs.poziomOdpaduTab.lgOrders)
            {
                finishedOrders = finishedOrders.Where(order => order.Value.kitting.odredGroup != "LG");
            }
            if (!DataContainer.guiState.viTabs.poziomOdpaduTab.mstOrders)
            {
                finishedOrders = finishedOrders.Where(order => order.Value.kitting.odredGroup != "MST");
            }
            var sortedOrders = finishedOrders.OrderBy(o => o.Value.kitting.endDate);
            string lineKey = DataContainer.guiState.viTabs.poziomOdpaduTab.cumulatedLines ? "Skumulowany" : "Po linii";
            string[] selectedLines = DataContainer.guiState.viTabs.poziomOdpaduTab.selectedLines;

            Dictionary<string, Dictionary<string, WastePerPointStruct>> chartPoints = new Dictionary<string, Dictionary<string, WastePerPointStruct>>();

            foreach (var smtLine in selectedLines)
            {
                chartPoints.Add(smtLine, new Dictionary<string, WastePerPointStruct>());
            }

            foreach (var orderEntry in sortedOrders)
            {
                if (orderEntry.Value.smt.totalManufacturedQty == 0) continue;
                if (lineKey != "Skumulowany")
                {
                    lineKey = orderEntry.Value.smt.smtOrders[0].smtLine;
                    if (!selectedLines.Contains(lineKey)) continue;
                }
                string dateKey = GetDateKey(DataContainer.guiState.viTabs.poziomOdpaduTab.timeInterval, orderEntry.Value.kitting.endDate);

                foreach (var lineEntry in chartPoints)
                {
                    if (!chartPoints[lineEntry.Key].ContainsKey(dateKey))
                    {
                        chartPoints[lineEntry.Key].Add(dateKey, new WastePerPointStruct());
                    }
                }

                chartPoints[lineKey][dateKey].totalProduction += orderEntry.Value.smt.totalManufacturedQty;
                chartPoints[lineKey][dateKey].totalNg += orderEntry.Value.visualInspection.ngCount;
                chartPoints[lineKey][dateKey].totalScrap += orderEntry.Value.visualInspection.scrapCount;
            }

            SeriesCollection seriesCollection = new SeriesCollection();

            ChartValues<float> totalProdValues = new ChartValues<float>();
            List<string> labels = new List<string>();
            foreach (var dateEntry in chartPoints[chartPoints.Select(k=>k.Key).First()])
            {
                labels.Add(dateEntry.Key);
                totalProdValues.Add(0);
            }


            foreach (var lineEntry in chartPoints)
            {
                int day = 0;
                foreach (var dateKey in labels)
                {
                    totalProdValues[day] += lineEntry.Value[dateKey].totalProduction;
                    day++;
                }
            }

            ColumnSeries totalProductionSeries = new ColumnSeries();
            totalProductionSeries.Fill = new SolidColorBrush
            {
                Color = System.Windows.Media.Color.FromArgb(255, 50, 50, 50),
                Opacity = .4
                
            };
            totalProductionSeries.ScalesYAt = 0;
            totalProductionSeries.Values = totalProdValues;
            totalProductionSeries.Title = "Produkcja";

            
            

            Axis axX = new Axis();
            axX.Labels = labels;
            

            Axis axY1 = new Axis();
            axY1.Position = AxisPosition.RightTop;
            axY1.Separator.IsEnabled = false;
            Axis axY2 = new Axis();
            


            poziomOdpaduChart.AxisX.Add(axX);
            poziomOdpaduChart.AxisY.Add(axY1);
            poziomOdpaduChart.AxisY.Add(axY2);
            seriesCollection.Add(totalProductionSeries);

            
            foreach (var lineEntry in chartPoints)
            {
                ChartValues<float> ngValues = new ChartValues<float>();
                ChartValues<float> scrapValues = new ChartValues<float>();
                
                foreach (var dateEntry in lineEntry.Value)
                {
                    if (dateEntry.Value.totalProduction > 0)
                    {
                        ngValues.Add((float)Math.Round((float)dateEntry.Value.totalNg / (float)dateEntry.Value.totalProduction * 100,2));
                        scrapValues.Add((float)Math.Round((float)dateEntry.Value.totalScrap / (float)dateEntry.Value.totalProduction * 100,2));

                    }
                    else
                    {
                        ngValues.Add(0);
                        scrapValues.Add(0);
                    }
                    
                }

                LineSeries ngSeries = new LineSeries();
                ngSeries.Title = $"ng_{lineEntry.Key}"; 
                ngSeries.Values = ngValues;
                ngSeries.DataLabels = true;
                ngSeries.ScalesYAt = 1;
                Func<ChartPoint, string> ngPt = pt => Math.Round(pt.Y, 2).ToString() + "%";
                ngSeries.LabelPoint = ngPt;
                ngSeries.Stroke = MediaTools.ColorDrawingToMediaBrush(GlobalParameters.smtLinesColors[lineEntry.Key.ToUpper()]);
                ngSeries.Fill = new SolidColorBrush
                {
                    Color = MediaTools.ColorDrawingToColorMedia(GlobalParameters.smtLinesColors[lineEntry.Key.ToUpper()]),
                    Opacity = 0.4
                };
                ngSeries.PointGeometry = DefaultGeometries.Square;

                LineSeries scrapSeries = new LineSeries();
                scrapSeries.Values = scrapValues;
                scrapSeries.Title = $"scrap_{lineEntry.Key}";
                scrapSeries.LabelPoint = ngPt;
                scrapSeries.DataLabels = true;
                scrapSeries.ScalesYAt = 1;
                scrapSeries.Fill = new SolidColorBrush
                {
                    Color = (MediaTools.ColorDrawingToColorMedia(GlobalParameters.smtLinesColors[lineEntry.Key.ToUpper()])),
                    Opacity = 0.4
                };
                scrapSeries.Stroke = MediaTools.ColorDrawingToMediaBrush(GlobalParameters.smtLinesColors[lineEntry.Key.ToUpper()]);
                seriesCollection.Add(ngSeries);
                seriesCollection.Add(scrapSeries);

                //poziomOdpaduChart.Series.Add(ngSeries);
                //poziomOdpaduChart.Series.Add(scrapSeries);
            }

            poziomOdpaduChart.Series.AddRange(seriesCollection);
            poziomOdpaduChart.Zoom = ZoomingOptions.Xy;
            poziomOdpaduChart.Pan = PanningOptions.Xy;
        }
    }
}
