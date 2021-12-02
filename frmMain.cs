using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarla
{
    public partial class frmMain : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int LoginId = 0;
        public static bool BankPermission = false;
        public static bool SettingPermission = false;
        public static bool UserPermission = false;
        bool? roleExists;
        bool? userExists;
        bool? settingExists;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            db.ExistsRoles(ref roleExists);
            if (roleExists==false)
            {
                frmAddRole.ExitType = true;
                frmAddRole.IsEdit = false;
                new frmAddRole().ShowDialog();
            }
            db.ExistsUsers(ref userExists);

            if (userExists == false)
            {
                frmAddUsers.ExitType = true;
                frmAddUsers.IsEdit = false;

                new frmAddUsers().ShowDialog();
            }
            else
            {
                new frmLogin().ShowDialog();
            }
            db.ExistsSetting(ref settingExists);
            if (settingExists==false)
            {
                frmSettings.ExitType = true;
                new frmSettings().ShowDialog();
            }
        }
    }
}
