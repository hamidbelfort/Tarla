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
namespace Tarla.MainForms
{
    public partial class frmAddBank : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int bankId = 0;
        public static bool IsEdit;
        public frmAddBank()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddBank_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsBank.DataSource = db.FillBankById(bankId);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام حساب الزامی است");
                    txtName.Focus();
                }
                else if (string.IsNullOrEmpty(txtOwner.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtName, "نام حساب الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsBank.EndEdit();
                        db.UpdateBank(bankId, txtName.Text, txtBankNumber.Text, txtOwner.Text, txtDesc.Text);
                    }
                    else
                    {
                        db.InsertBank(txtName.Text, txtBankNumber.Text, txtOwner.Text, txtDesc.Text);
                        clearAll();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void clearAll()
        {
            txtBankNumber.Text = string.Empty;
            txtDesc.Clear();
            txtName.Clear();
            txtOwner.Clear();
            txtName.Focus();
        }
    }
}
