using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarla.Classes
{
    class Util
    {
        public static bool IsEnglishCharacter(char ch)
        {
            if (ch >= 97 && ch <= 122 || ch >= 65 && ch <= 90)
            {
                return true;
            }

            return false;
        }
        public static int removeThousandSeprator(string number)
        {
            number=number.Replace(",", "");
            return Convert.ToInt32(number);
        }
        public void SaveLog(string formName,string message)
        {
            dcTarlaDataContext db = new dcTarlaDataContext();
            try
            {
                PersianDate pd = new PersianDate();
                string strDate = pd.getShortDateTime();
                db.InsertSystemLog(strDate,message,formName);
            }
            catch
            {

            }
        }
    }
}
