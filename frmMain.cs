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
    }
}
