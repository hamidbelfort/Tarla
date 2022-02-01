using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
namespace Tarla.Classes
{
    class Toast
    {
        
        public void InfoToast(System.Windows.Forms.Control parent,string message,string title,int interval)
        {
            ToastNotification.Show(parent, message, null, interval, eToastGlowColor.Blue, eToastPosition.BottomCenter);
        }
        public void WarningToast(System.Windows.Forms.Control parent, string message, string title, int interval)
        {
            ToastNotification.Show(parent, message, null, interval, eToastGlowColor.Orange, eToastPosition.BottomCenter);
        }
        public void ErrorToast(System.Windows.Forms.Control parent, string message, string title, int interval)
        {
            ToastNotification.Show(parent, message, null, interval, eToastGlowColor.Red, eToastPosition.BottomCenter);
        }
        public void SuccessToast(System.Windows.Forms.Control parent, string message, string title, int interval)
        {
            ToastNotification.Show(parent, message, null, interval, eToastGlowColor.Green, eToastPosition.BottomCenter);
        }
    }
}
