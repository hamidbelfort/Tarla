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
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public static int LoginId = 0;
        public static bool BankPermission = false;
        public static bool SettingPermission = false;
        public static bool UserPermission = false;
        public static bool FactorPermission = false;
        public static string Fullname = "";
        bool? roleExists;
        bool? userExists;
        bool? settingExists;
        int? logId;
        double? fontSize;
        string themeName;
        string strToday;
        string wallpaper;
        public int childCount;
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
            lblFullname.Text = string.Format("کاربر جاری : {0}", Fullname);
            lblDate.Text = string.Format("تاریخ : {0}",pd.getShortDate());
            this.WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
        }
        private void getThemSetting()
        {
            try
            {
                db.GetThemeSetting(ref themeName, ref fontSize);
                db.GetWallpaper(ref wallpaper);
                styleManager1.ManagerStyle = StyleTheme.getTheme(themeName);
                this.Font = new Font("Tahoma", (float)fontSize, FontStyle.Regular);
                if (wallpaper!=string.Empty)
                {
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    this.BackgroundImage = Image.FromFile(wallpaper);
                }
                else
                {
                    this.BackgroundImage = null;
                }
            }
            catch
            {

            }
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowProducts _frmChild = new frmShowProducts();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowGroups _frmChild = new frmShowGroups();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowCompany _frmChild = new frmShowCompany();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnBuyers_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowPerson.personType = 1;
            frmShowPerson _frmChild = new frmShowPerson();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowPerson.personType = 2;
            frmShowPerson _frmChild = new frmShowPerson();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnReceivers_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowPerson.personType = 3;
            frmShowPerson _frmChild = new frmShowPerson();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowItem _frmChild = new frmShowItem();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnItemGroup_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowItemGroup _frmChild = new frmShowItemGroup();
            _frmChild.MdiParent = this;
            _frmChild.Show();
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
            minimizeRibbon(true);
            frmShowPacking _frmChild = new frmShowPacking();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmAddFactor _frmChild = new frmAddFactor();
            _frmChild.MdiParent = this;
            _frmChild.Text = "ثبت حواله فروش";
            _frmChild.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowBank _frmChild = new frmShowBank();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowUsers _frmChild = new frmShowUsers();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmChangePass.userId = LoginId;
            frmChangePass _frmChild = new frmChangePass();
            _frmChild.MdiParent = this;
            _frmChild.Show();
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
            try
            {
                getThemSetting();
            }
            catch
            {
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmBuyItem _frmChild = new frmBuyItem();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowBooks _frmChild = new frmShowBooks();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnFReceiver_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowForiegnReceiver _frmChild = new frmShowForiegnReceiver();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowMessage _frmChild = new frmShowMessage();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnFactorList_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowFactor _frmChild = new frmShowFactor();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            new frmChangeWallpaper().ShowDialog();
            getThemSetting();
        }

        private void switchRibbon_ValueChanged(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = switchRibbon.Value;
        }

        private void ماشینحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void نقاشیویندوزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }
        private void minimizeRibbon(bool shouldMinimize)
        {
            switchRibbon.Value = !shouldMinimize;
            ribbonControl1.Expanded = !shouldMinimize;
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowDriver _frmChild = new frmShowDriver();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            minimizeRibbon(true);
            frmShowDepots _frmChild = new frmShowDepots();
            _frmChild.MdiParent = this;
            _frmChild.Show();
        }
    }
}
