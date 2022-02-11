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

namespace Tarla.MiscForms
{
    public partial class frmAddUser : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int userId = 0;
        public static bool ExitType = false;
        public static int RoleId = 0;
        bool? CheckName = false;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                bsRoles.DataSource = db.FillRoles();
                if (IsEdit)
                {
                    bsUser.DataSource = db.FillUsersById(userId);
                    cmbRoles.SelectedValue = RoleId;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbRoles.Text))
                {
                    errorProvider1.SetError(cmbRoles, "یک نقش کاربری را انتخاب کنید");
                    cmbRoles.Focus();
                }
                else if (string.IsNullOrEmpty(txtFullname.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtFullname, "نام و نام خانوادگی الزامی است");
                    txtFullname.Focus();
                }
                else if (string.IsNullOrEmpty(txtUser.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUser, "نام کاربری الزامی است");
                    txtUser.Focus();
                }
                else if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUser, "رمز عبور الزامی است");
                    txtPass.Focus();
                }
                else
                {
                    
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsUser.EndEdit();
                        db.UpdateUsers(userId, (int)cmbRoles.SelectedValue, txtFullname.Text, txtUser.Text.Trim(), txtPass.Text);
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

                            db.InsertUser((int)cmbRoles.SelectedValue,txtFullname.Text, txtUser.Text.Trim(), txtPass.Text);

                            if (ExitType == true)
                            {
                                this.Close();
                            }

                            txtUser.Text = string.Empty;
                            txtPass.Text = string.Empty;

                            txtUser.Focus();
                        }
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            Keys key = (Keys)e.KeyChar;

            if (key == Keys.Back)
            {
                return;
            }

            if (!Util.IsEnglishCharacter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtUser,"نام کاربری باید با حروف انگلیسی باشد");
            }
        }
    }
}
