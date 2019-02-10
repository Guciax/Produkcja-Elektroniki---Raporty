using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkcja_Elektroniki___Raporty.Tools
{
    public class DateTools
    {
        public static int DateToShiftrNumber(DateTime date)
        {
            if (date.Hour < 6) return 3;
            if (date.Hour < 14) return 1;
            if (date.Hour < 22) return 2;
            return 3;
        }

        public static int GetWeekNoOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return (time.Year - 2000) * 100 + CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
