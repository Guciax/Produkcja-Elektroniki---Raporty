using LiveCharts.WinForms;
using MST.MES;
using PresentationControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produkcja_Elektroniki___Raporty
{
    public class DataContainer
    {
        public static Dictionary<string, OrderStructureByOrderNo.OneOrderData> sqlDataByOrder = new Dictionary<string, OrderStructureByOrderNo.OneOrderData>();
        public static Dictionary<int, string> testerIdToName = new Dictionary<int, string>();
        public static Dictionary<string, string> nc12ToName;
        public static GuiState guiState;
        //components
        public static CartesianChart poziomOdpaduChart;
        public static CheckBoxComboBox viPoziomOdpaduLines;
    }
}
