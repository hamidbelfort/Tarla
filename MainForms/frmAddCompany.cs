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

namespace Tarla.MainForms
{
    public partial class frmAddCompany : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int companyId = 0;
        public static bool IsEdit;
        public frmAddCompany()
        {
            InitializeComponent();
        }

        private void frmAddCompany_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsCompany.DataSource = db.FillCompanyById(companyId);
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
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام شرکت الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsCompany.EndEdit();
                        db.UpdateCompany(companyId, txtName.Text.Trim(),txtChief.Text,txtPhone.Text,txtAddress.Text);
                    }
                    else
                    {
                        db.InsertCompany(txtName.Text.Trim(), txtChief.Text, txtPhone.Text, txtAddress.Text);
                        clearAll();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void clearAll()
        {
            txtAddress.Clear();
            txtChief.Clear();
            txtName.Clear();
            txtPhone.Text = string.Empty;
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
