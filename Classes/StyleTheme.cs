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
        public enum styles
        {
            OfficeMobile2014,
            Office2016,
            VisualStudio2012Light,
            VisualStudio2010Blue,
            Windows7Blue,
            Office2010Black,
            Office2010Blue,
            Office2007VistaGlass,
            Office2007Black,
            Office2007Silver,
            Office2007Blue

        };
        public static List<string> getThemeList()
        {
            List<string> styleList = new List<string>();
            foreach (styles val in Enum.GetValues(typeof(styles)))
            {
                styleList.Add((val).ToString());
            }
            return styleList;
        }
        
        public eStyle getThemeName(int styleIndex)
        {
            switch (styleIndex)
            {
                case 0:
                    return eStyle.OfficeMobile2014;
                case 1:
                    return eStyle.Office2016;
                case 2:
                    return eStyle.VisualStudio2012Light;
                case 3:
                    return eStyle.VisualStudio2010Blue;
                case 4:
                    return eStyle.Windows7Blue;
                case 5:
                    return eStyle.Office2010Black;
                case 6:
                    return eStyle.Office2010Blue;
                case 7:
                    return eStyle.Office2007VistaGlass;
                case 8:
                    return eStyle.Office2007Black;
                case 9:
                    return eStyle.Office2007Silver;
                case 10:
                    return eStyle.Office2007Blue;
                default:
                    return eStyle.OfficeMobile2014;
            }
        }
    }
}
