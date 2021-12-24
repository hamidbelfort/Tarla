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
using Tarla.MiscForms;
using Tarla.OperationForms;
namespace Tarla
{
    public partial class frmMain : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public static int LoginId = 0;
        public static bool BankPermission = false;
        public static bool SettingPermission = false;
        public static bool UserPermission = false;
        public static bool FactorPermission = false;
        bool? roleExists;
        bool? userExists;
        bool? settingExists;
        int? logId;
        double? fontSize;
        string themeName;
        string strToday;
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
                getThemSetting();
            }
            else
            {
                getThemSetting();
            }
            btnBank.Enabled = BankPermission;
            btnBook.Enabled = BankPermission;
            btnSettings.Enabled = SettingPermission;
            btnUsers.Enabled = UserPermission;
            btnSell.Enabled = FactorPermission;
            btnBuy.Enabled = FactorPermission;
            btnProduct.Enabled = FactorPermission;
            btnCategory.Enabled = FactorPermission;
            btnItem.Enabled = FactorPermission;
            btnItemGroup.Enabled = FactorPermission;
            btnPacking.Enabled = FactorPermission;
        }
        private void getThemSetting()
        {
            try
            {
                db.GetThemeSetting(ref themeName, ref fontSize);
                styleManager1.ManagerStyle = StyleTheme.getTheme(themeName);
                this.Font = new Font("Tahoma", (float)fontSize, FontStyle.Regular);
            }
            catch
            {

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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                strToday = pd.getShortDateTime();
                db.GetLogId(ref logId, LoginId);
                db.UpdateLog(logId, strToday);
            }
            catch
            {

            }
        }

        private void btnPacking_Click(object sender, EventArgs e)
        {
            new frmShowPacking().ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new frmAddInvoice().ShowDialog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            new frmShowBank().ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new frmShowUsers().ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePass.userId = LoginId;
            new frmChangePass().ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            new frmBackUp().ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            new frmRestore().ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            new frmShowRoles().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new frmBuyItem().ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           
        }
    }
}
