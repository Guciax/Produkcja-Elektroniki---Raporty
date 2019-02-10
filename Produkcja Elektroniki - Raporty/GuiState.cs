using LiveCharts.WinForms;
using MST.MES;
using Produkcja_Elektroniki___Raporty.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produkcja_Elektroniki___Raporty
{
    public class GuiState
    {
        public ViTabs viTabs = new ViTabs();

        public class ViTabs
        {
            public PoziomOdpaduTab poziomOdpaduTab = new PoziomOdpaduTab() { mstOrders=true,lgOrders=true,cumulatedLines=true,  startDate = DateTime.Now.AddDays(-30), endDate = DateTime.Now, timeInterval="Dziennie" , SMT2=true, SMT3=true, SMT4=true, SMT5=true, SMT6=true, SMT7=true, SMT8=true};

            public class PoziomOdpaduTab
            {
                MainWindow mainW = new MainWindow();

                private bool _cumulatedLines;

                public bool mstOrders { get; set; }
                public bool lgOrders { get; set; }
                public DateTime startDate { get; set; }
                public DateTime endDate { get; set; }
                public bool cumulatedLines
                {
                    get { return _cumulatedLines; }
                    set {
                        _cumulatedLines = value;
                        ViViewModels.DrawPoziomOdpaduChart();
                    }
                }

                public string selectedLineItem
                {
                    get { return _selectedLineItem; }
                    set { _selectedLineItem = value;
                        ViViewModels.DrawPoziomOdpaduChart();
                    }
                }
                private string _selectedLineItem = "";

                public bool SMT2 { get; set; }
                public bool SMT3 { get; set; }
                public bool SMT4 { get; set; }
                public bool SMT5 { get; set; }
                public bool SMT6 { get; set; }
                public bool SMT7 { get; set; }
                public bool SMT8 { get; set; }
                public bool byLine
                {
                    get
                    {
                        return !cumulatedLines;
                    }
                    
                }

                public string timeInterval
                {
                    get;set;
                }
                public string[] selectedLines
                {
                    get {
                        if (cumulatedLines) return new string[] { "Skumulowany" };
                        List<string> result = new List<string>();
                        foreach (var item in DataContainer.viPoziomOdpaduLines.CheckBoxItems)
                        {
                            if (item.Checked) result.Add(item.Text);
                        }
                        return result.ToArray();
                    }
                }
                public CartesianChart ChartPoziomOdpadu { get; }
            }
        }
    }
}
