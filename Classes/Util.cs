using System;
using System.Collections.Generic;
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
    }
}
