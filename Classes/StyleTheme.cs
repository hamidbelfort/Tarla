using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
namespace Tarla.Classes
{
    class StyleTheme
    {
        
        public static List<string> getThemeList()
        {
            List<string> styleList = new List<string>();
            foreach (eStyle val in Enum.GetValues(typeof(eStyle)))
            {
                styleList.Add((val).ToString());
            }
            return styleList;
        }
        public static eStyle getTheme(string themeName)
        {
            
            eStyle result = (eStyle)Enum.Parse(typeof(eStyle),themeName);
            return result;
        }
        
    }
}
