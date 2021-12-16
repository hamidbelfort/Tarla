using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarla.Classes;
using Tarla.MainForms;
using Tarla.OperationForms;
namespace Tarla
{
    public partial class frmMain : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int LoginId = 0;
        public static bool BankPermission = false;
        public static bool SettingPermission = false;
        public static bool UserPermission = false;
        public static bool FactorPermission = false;
        bool? roleExists;
        bool? userExists;
        bool? settingExists;
        double? fontSize;
        string themeName;
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(runSplash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        private void runSplash()
        {
            Application.Run(new frmSplash());
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
                db.GetThemeSetting(ref themeName,ref fontSize);
            }
            else
            {
                db.GetThemeSetting(ref themeName, ref fontSize);
                styleManager1.ManagerStyle = StyleTheme.getTheme(themeName);
                this.Font = new Font("Tahoma", (float)fontSize, FontStyle.Regular);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new frmShowProducts().ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new frmShowGroups().ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            new frmShowCompany().ShowDialog();
        }

        private void btnBuyers_Click(object sender, EventArgs e)
        {
            frmShowPerson.personType = 1;
            new frmShowPerson().ShowDialog();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            frmShowPerson.personType = 2;
            new frmShowPerson().ShowDialog();
        }

        private void btnReceivers_Click(object sender, EventArgs e)
        {
            frmShowPerson.personType = 3;
            new frmShowPerson().ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            new frmShowItem().ShowDialog();
        }

        private void btnItemGroup_Click(object sender, EventArgs e)
        {
            new frmShowItemGroup().ShowDialog();
        }
    }
}
