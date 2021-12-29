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
    public partial class frmAddNetSell : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int invoiceId;
        int? netsell;
        int? profit;
        int? loss;
        int? totalPrice;
        int newNetSell;
        public frmAddNetSell()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (intNetSell.Value==0)
                {
                    errorProvider1.SetError(intNetSell,"مقدار صافی فروش را وارد کنید");
                    intNetSell.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (MessageBoxFarsi.Show("آیا از بروزرسانی اطلاعات فاکتور اطمینان دارید؟", "ذخیره فاکتور", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Information) == DialogResult.Yes)
                    {
                        int _profit=Convert.ToInt32(txtProfit.Text);
                        int _loss = Convert.ToInt32(txtLoss.Text);
                        db.UpdateInvoiceNetSell(invoiceId, intNetSell.Value, _profit, _loss);
                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        txtLoss.Text = "0";
                        txtProfit.Text= "0";
                        txtTotalPrice.Text= "0";
                        intNetSell.Value = 0;
                        btnSave.Enabled = false;
                    }
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void frmAddNetSell_Load(object sender, EventArgs e)
        {
            try
            {
                db.GetFactorNetSell(invoiceId, ref netsell, ref totalPrice, ref profit, ref loss);
                txtLoss.Text = Convert.ToInt32(loss).ToString("N0");
                txtProfit.Text = Convert.ToInt32(profit).ToString("N0");
                txtTotalPrice.Text = Convert.ToInt32(totalPrice).ToString("N0");
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void intNetSell_ValueChanged(object sender, EventArgs e)
        {
            if (intNetSell.Value > 0)
            {
                newNetSell = intNetSell.Value;
            }
            else
            {
                newNetSell = 0;
            }
            calculateProfitLoss();
        }
        private void calculateProfitLoss()
        {
            int result = 0;
            int _profit = 0;
            int _loss = 0;
            if (newNetSell > 0)
            {
                result = Util.removeThousandSeprator(txtTotalPrice.Text) - newNetSell;
                if (result < 0)
                {
                    _profit = Math.Abs(result);
                    txtLoss.Text = "0";
                    txtProfit.Text = _profit.ToString("N0");
                }
                else
                {
                    _loss = result;
                    txtProfit.Text = "0";
                    txtLoss.Text = _loss.ToString("N0");
                }
            }
            else
            {
                _profit = 0;
                _loss = 0;
                txtProfit.Text = "0";
                txtLoss.Text = "0";
            }
        }
    }
}
