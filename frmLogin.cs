using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BehComponents;
using Tarla.Classes;

namespace Tarla
{
    public partial class frmLogin : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        int? userId = 0;
        bool? checkUsername = false;
        bool? checkPass = false;
        bool? Bank = false;
        bool? Setting = false;
        bool? User = false;
        bool? factor = false;
        PersianDate pd = new PersianDate();
        string strToday;
        public static float fontSize;
        public static string themeName;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                db.CheckUsersName(ref checkUsername, txtUsername.Text.Trim());
                db.CheckUserPass(ref checkPass, txtPassword.Text.Trim());
                if (checkUsername == true && checkPass == true)
                {
                    db.GetLoginId(ref userId, txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    db.GetUserPermissions(userId, ref Setting, ref Bank, ref User, ref factor);
                    frmMain.LoginId = (int)userId;

                    frmMain.BankPermission = (bool)Bank;
                    frmMain.SettingPermission = (bool)Setting;
                    frmMain.UserPermission = (bool)User;
                    frmMain.FactorPermission = (bool)factor;
                    strToday = pd.getShortDateTime();

                    db.InsertLog(userId, strToday);

                    Close();
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "مشخصات کاربری اشتباه است");
                    txtPassword.Focus();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("آیا از خروج اطمینان دارید؟","خروج",MessageBoxFarsiButtons.YesNo,MessageBoxFarsiIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //styleManager1.ManagerStyle = StyleTheme.getTheme(themeName);
            //this.Font = new Font("Tahoma", fontSize, FontStyle.Regular);
        }
    }
}
