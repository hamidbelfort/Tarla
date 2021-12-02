using BehComponents;
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
    public partial class frmAddUsers : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool ExitType = false;
        public static bool IsEdit = false;
        public static int userId=0;
        public static int roleId = 0;
        bool? CheckName;
        public frmAddUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == string.Empty)
                {
                    errorProvider1.SetError(txtUser, "مقداری را مشخص نکرده اید");

                    txtUser.Focus();
                }
                else if (txtPass.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtPass, "مقداری را مشخص نکرده اید");

                    txtPass.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsUser.EndEdit();
                        db.UpdateUsers(userId, (int)cmbRoles.SelectedValue,txtFullname.Text, txtUser.Text, txtPass.Text);
                    }
                    else
                    {
                        db.CheckUsersName(ref CheckName, txtUser.Text);

                        if (CheckName == true)
                        {
                            errorProvider1.SetError(txtUser, "نام کاربری تکراری است");

                            txtUser.Focus();
                        }
                        else
                        {
                            errorProvider1.Clear();

                            db.InsertUser((int)cmbRoles.SelectedValue,txtFullname.Text, txtUser.Text, txtPass.Text);

                            if (ExitType == true)
                            {
                                this.Close();
                            }

                            txtUser.Text = string.Empty;
                            txtPass.Text = string.Empty;

                            txtUser.Focus();
                        }
                    }
                }

                MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            try
            {
                bsRoles.DataSource = db.FillRoles();
                if (IsEdit)
                {
                    bsUser.DataSource = db.FillUsersById(userId);
                    cmbRoles.SelectedValue = roleId;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frmAddUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }
    }
}
