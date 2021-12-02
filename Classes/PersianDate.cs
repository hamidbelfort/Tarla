using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarla.Classes
{
    public class PersianDate
    {
        PersianCalendar PC = new PersianCalendar();
        public string getShortDateTime()
        {
           return PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();
        }
        public string getShortDate()
        {
            return PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00");
        }
    }
}
