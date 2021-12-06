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
    public partial class frmAddProduct : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int productId = 0;
        public static int groupId = 0;
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroup.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbGroup, "یک دسته بندی را انتخاب کنید");
                    cmbGroup.Focus();
                }
                else if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    errorProvider1.SetError(txtProductName, "نام محصول الزامی است");
                    txtProductName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsProduct.EndEdit();

                        db.UpdateProducts(productId, txtProductName.Text.Trim(), (int)cmbGroup.SelectedValue, txtDesc.Text);
                    }
                    else
                    {
                        db.InsertProducts(txtProductName.Text.Trim(), (int)cmbGroup.SelectedValue, txtDesc.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clearAll()
        {
            txtDesc.Clear();
            txtProductName.Clear();
            cmbGroup.Focus();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                bsGroups.DataSource = db.FillGroups();

                if (IsEdit)
                {
                    bsProduct.DataSource = db.FillProductsById(productId);

                    cmbGroup.SelectedValue = groupId;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
