using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkcja_Elektroniki___Raporty
{
    public class GlobalParameters
    {
        public static Dictionary<string, Color> smtLinesColors = new Dictionary<string, Color>
        { 
                { "SMT2", Color.FromArgb(255, 46, 204, 113) },
                { "SMT3", Color.FromArgb(255, 52, 152, 219) },
                { "SMT4", Color.FromArgb(255, 155, 89, 182) },
                { "SMT5", Color.FromArgb(255, 52, 73, 94) },
                { "SMT6", Color.FromArgb(255, 241, 196, 15) },
                { "SMT7", Color.FromArgb(255, 230, 126, 34) },
                { "SMT8", Color.FromArgb(255, 231, 76, 60) },
                { "SKUMULOWANY", Color.FromArgb(255, 22,160,133) }
        };

        public static List<string> smtLines = new List<string>();
    }
}
