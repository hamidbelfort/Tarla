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

namespace Tarla.MiscForms
{
    public partial class frmChangePass : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int userId;
        bool? CheckPass;
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Enabled = true;
                gp2.Enabled = false;

                btnSave.Enabled = false;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.CheckLoginPassById(userId, txtOldPass.Text, ref CheckPass);

                if (CheckPass == true)
                {
                    gp1.Enabled = false;
                    gp2.Enabled = true;
                    btnSave.Enabled = true;
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
                if (btnSave.Enabled)
                {


                    if (txtNewPass.Text == string.Empty)
                    {
                        errorProvider1.SetError(txtNewPass, "مقداری را مشخص نکرده اید");

                        txtNewPass.Focus();
                    }
                    else if (txtNewPass.Text != txtRePass.Text)
                    {
                        errorProvider1.Clear();

                        errorProvider1.SetError(txtRePass, "کلمه های عبور با یکدیگر همخوانی ندارند");

                        txtRePass.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();

                        db.UpdateLoginPass(userId, txtNewPass.Text);

                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    }
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
    }
}
