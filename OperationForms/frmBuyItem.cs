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
namespace Tarla.OperationForms
{
    public partial class frmBuyItem : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public static bool IsEdit;
        public static int companyId = 0;
        public static int itemId = 0;
        public static int buyId = 0;
        int totalPrice;
        public frmBuyItem()
        {
            InitializeComponent();
        }

        private void frmBuyItem_Load(object sender, EventArgs e)
        {
            try
            {
                bsItem.DataSource = db.FillItems();
                bsCompany.DataSource = db.FillCompany();
                if (IsEdit)
                {
                    bsBuy.DataSource = db.FillBuyItemById(buyId);
                    cmbCompany.SelectedValue = companyId;
                    cmbItem.SelectedValue = itemId;
                }
                else
                {
                    txtDate.Text = pd.getShortDate();
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
                if (string.IsNullOrEmpty(txtDate.Text))
                {
                    errorProvider1.SetError(txtDate,"تاریخ خرید را وارد کنید");
                }
                else if (string.IsNullOrEmpty(cmbCompany.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbCompany, "یک شرکت راانتخاب کنید");
                    cmbCompany.Focus();
                }
                else if (string.IsNullOrEmpty(cmbItem.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbItem, "یک کالا را انتخاب کنید");
                    cmbItem.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsBuy.EndEdit();
                        db.UpdateBuyItem(buyId, txtDate.Text, (int)cmbCompany.SelectedValue, (int)cmbItem.SelectedValue, intQty.Value, intPrice.Value, totalPrice, txtDesc.Text);
                    }
                    else
                    {
                        db.InsertBuyItem(txtDate.Text, (int)cmbCompany.SelectedValue, (int)cmbItem.SelectedValue, intQty.Value, intPrice.Value, totalPrice, txtDesc.Text);
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
            txtDate.Text = string.Empty;
            txtDesc.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = "0";
            txtDate.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void intQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (intQty.Value>0 && intPrice.Value>0)
                {
                    totalPrice = intPrice.Value * intQty.Value;
                }
                else
                {
                    totalPrice = 0;
                }
                lblTotalPrice.Text = totalPrice.ToString("N0");
            }
            catch
            {
            }
        }
    }
}
