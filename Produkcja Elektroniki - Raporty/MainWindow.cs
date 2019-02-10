using MST.MES;
using PresentationControls;
using Produkcja_Elektroniki___Raporty.ControlsConfig;
using Produkcja_Elektroniki___Raporty.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Produkcja_Elektroniki___Raporty.DataLoader.MergeData;
using static Produkcja_Elektroniki___Raporty.GuiState.ViTabs;

namespace Produkcja_Elektroniki___Raporty
{
    public partial class MainWindow : Form
    {
        OrderStructureByOrderNo.DataByProcess sqlDataByProcess = new OrderStructureByOrderNo.DataByProcess();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataContainer.poziomOdpaduChart = cartesianChart1;
            DataContainer.viPoziomOdpaduLines = checkBoxComboBox1;
            DataContainer.guiState = new GuiState();

            DataContainer.nc12ToName = MST.MES.SqlOperations.ConnectDB.Nc12ToModelFullDict();
            Debug.WriteLine("12nc dict");


            DataContainer.testerIdToName = MST.MES.SqlDataReaderMethods.LedTest.TesterIdToName();
            Debug.WriteLine("testIdToName");

            
            sqlDataByProcess.Kitting = MST.MES.SqlDataReaderMethods.Kitting.GetOrdersInfoByDataReader(30);
            Debug.WriteLine("testID");
            sqlDataByProcess.Smt = MST.MES.SqlDataReaderMethods.SMT.GetOrdersByDataReader(30);
            Debug.WriteLine("smt");
            sqlDataByProcess.VisualInspection = MST.MES.SqlDataReaderMethods.VisualInspection.GetViRecords(30);
            Debug.WriteLine("vi");
            //sqlDataByProcess.Test = MST.MES.SqlDataReaderMethods.LedTest.GetTestRecords(10, testerIdToName);
            Debug.WriteLine("test");
            //sqlDataByProcess.Rework = MST.MES.SqlDataReaderMethods.LedRework.GetReworkList(90);
            DataMerger.MergeData(ref DataContainer.sqlDataByOrder, sqlDataByProcess.Kitting, sqlDataByProcess.Smt, sqlDataByProcess.Test, sqlDataByProcess.VisualInspection, null);
            GlobalParameters.smtLines = sqlDataByProcess.Smt.SelectMany(o => o.Value.smtOrders).Select(line => line.smtLine).Distinct().OrderBy(l => l).ToList();

            foreach (var line in GlobalParameters.smtLines)
            {
                clbViPoziomOdpaduSmtLines.Items.Add(line, true);
                checkBoxComboBox1.Items.Add(line);
            }

            foreach (var ch in checkBoxComboBox1.CheckBoxItems)
            {
                ch.Checked = true;
            }
            checkBoxComboBox1.Capture = true;

            clbViPoziomOdpaduSmtLines.Parent = tab7;
            clbViPoziomOdpaduSmtLines.BringToFront();
            clbViPoziomOdpaduSmtLines.Location = new Point(300, 30);


            //-------------------Components binding
            //-----------Kontrola wzrokowa
            //--Poziom odpadu
            cBViPoziomOdpaduLG.DataBindings.Add(new Binding("Checked", DataContainer.guiState.viTabs.poziomOdpaduTab, "lgOrders", false, DataSourceUpdateMode.OnPropertyChanged));
            cBViPoziomOdpaduMst.DataBindings.Add(new Binding("Checked", DataContainer.guiState.viTabs.poziomOdpaduTab, "mstOrders", false, DataSourceUpdateMode.OnPropertyChanged));
            dtpViPoziomOdpaduStart.DataBindings.Add(new Binding("Value", DataContainer.guiState.viTabs.poziomOdpaduTab, "startDate", false, DataSourceUpdateMode.OnPropertyChanged));
            dtpViPoziomOdpaduEnd.DataBindings.Add(new Binding("Value", DataContainer.guiState.viTabs.poziomOdpaduTab, "endDate", false, DataSourceUpdateMode.OnPropertyChanged));
            rbViPoziomOdpaduCumulated.DataBindings.Add(new Binding("Checked", DataContainer.guiState.viTabs.poziomOdpaduTab, "cumulatedLines", false, DataSourceUpdateMode.OnPropertyChanged));
            cbViPoziomOdpaduInterval.DataBindings.Add(new Binding("Text", DataContainer.guiState.viTabs.poziomOdpaduTab, "timeInterval", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxComboBox1.DataBindings.Add(new Binding("SelectedItem", DataContainer.guiState.viTabs.poziomOdpaduTab, "selectedLineItem", false, DataSourceUpdateMode.OnPropertyChanged));
            //--Przyczyny odpadu

            olvLastNgs.Configurate(ref olvViLastNg);
            olvViLastNg.SetObjects(ViViewModels.LastNgSource());
            olvLastNgs.AutoResizeColumns(ref olvViLastNg);

            ViViewModels.DrawPoziomOdpaduChart();
        }

        private void rbViPoziomOdpaduByLine_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbViPoziomOdpaduByLine.Checked)
            //{
            //    cbcbViPoziomOdpaduSmtLines.Visible = true;
            //}
            //else
            //{
            //    cbcbViPoziomOdpaduSmtLines.Visible = false;
            //}

        }
        


    }
}
