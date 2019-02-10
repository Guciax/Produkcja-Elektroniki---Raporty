using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Produkcja_Elektroniki___Raporty.ViewModels.ViViewModels;

namespace Produkcja_Elektroniki___Raporty.ControlsConfig
{
    public class olvLastNgs
    {
        public static void Configurate(ref ObjectListView olv)
        {
            olv.ShowGroups = true;
            olv.UseAlternatingBackColors = true;
            olv.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(olv_CellToolTipShowing);
            olv.CellToolTip.Font = new Font("Tahoma", 14);

            OLVColumn dateCol = new OLVColumn();
            dateCol.Text = "Data";
            dateCol.AspectName = "Date";
            //dateCol.AspectToStringFormat ="ToString(HH:mm dd-MM)";
            dateCol.GroupKeyGetter = delegate (object rowObject) {
                LastNgViewColumns col = (LastNgViewColumns)rowObject;
                return new DateTime(col.Date.Year, col.Date.Month, col.Date.Day);
            };
            dateCol.GroupKeyToTitleConverter = delegate (object groupKey) {
                return ((DateTime)groupKey).ToString("dd-MMM-yyyy");
            };
            olv.Columns.Add(dateCol);

            OLVColumn orderCol = new OLVColumn();
            orderCol.Text = "Zlecenie";
            orderCol.AspectName = "OrderNo";
            olv.Columns.Add(orderCol);

            OLVColumn modelIdCol = new OLVColumn();
            modelIdCol.Text = "ID";
            modelIdCol.AspectName = "ModelId";
            olv.Columns.Add(modelIdCol);

            OLVColumn ngCountCol = new OLVColumn();
            ngCountCol.Text = "NG";
            ngCountCol.AspectName = "NgCount";
            olv.Columns.Add(ngCountCol);

            OLVColumn scrapCountCol = new OLVColumn();
            scrapCountCol.Text = "SCRAP";
            scrapCountCol.AspectName = "ScrapCount";
            olv.Columns.Add(scrapCountCol);


        }

        private static void olv_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            ObjectListView l = (ObjectListView)sender;

            LastNgViewColumns s = (LastNgViewColumns)e.Model;
            e.Text = s.ModelName;
        }

        public static void AutoResizeColumns(ref ObjectListView olv)
        {
            foreach (OLVColumn col in olv.Columns)
            {
                col.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}
