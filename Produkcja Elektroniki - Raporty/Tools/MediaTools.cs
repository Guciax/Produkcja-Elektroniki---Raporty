using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkcja_Elektroniki___Raporty.Tools
{
    public class MediaTools
    {
        public static System.Windows.Media.Color ColorDrawingToColorMedia(System.Drawing.Color clr)
        {
           return  System.Windows.Media.Color.FromRgb(clr.R, clr.G, clr.B);
        }

        public static System.Windows.Media.SolidColorBrush ColorDrawingToMediaBrush(System.Drawing.Color clr)
        {
            return new System.Windows.Media.SolidColorBrush(ColorDrawingToColorMedia(clr));
        }
    }
}
