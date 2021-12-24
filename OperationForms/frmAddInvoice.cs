using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarla.Classes;

namespace Tarla.OperationForms
{
    public partial class frmAddInvoice : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int totalPrice, totalWeight;
        public frmAddInvoice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab==superTabItem1)
            {
                if (cmbBuyer.Text==string.Empty)
                {
                    errorProvider1.SetError(cmbBuyer, "خریدار را انتخاب کنید");
                    cmbBuyer.Focus();
                }
                else if (cmbBandarReceiver.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbBandarReceiver, "گیرنده بندر را انتخاب کنید");
                    cmbBandarReceiver.Focus();
                }
                else if (cmbDubaiReceiver.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbDubaiReceiver, "گیرنده دوبی را انتخاب کنید");
                    cmbDubaiReceiver.Focus();
                }
                else if (dgvFactor.Rows.Count<0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbProduct, "محصول را انتخاب کنید");
                    errorProvider1.SetError(cmbSeller, "فروشنده را انتخاب کنید");
                    errorProvider1.SetError(cmbPacking, "نوع بسته بندی را انتخاب کنید");
                    cmbProduct.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    calculateTotalPrice();
                    txtTotalProducts.Text = totalPrice.ToString("N0");
                    btnNext.Enabled = false;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text = pd.getShortDate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvFactor.Rows.Add(cmbProduct.Text, intPrice.Text, intCount.Text, intWeight.Text, cmbSeller.Text, cmbPacking.Text, cmbProduct.SelectedValue, cmbSeller.SelectedValue, cmbPacking.SelectedValue);
            calculateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvFactor.Rows.RemoveAt(dgvFactor.CurrentRow.Index);
        }

        private void calculateTotalPrice()
        {
            totalPrice = 0;
            totalWeight = 0;
            for (int i = 0; i < dgvFactor.Rows.Count; i++)
            {
                totalPrice += (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmQty"].Value.ToString())) * (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPrice"].Value.ToString()));
                totalWeight += (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString()));
            }
            lblTotalPrice.Text = totalPrice.ToString("N0");
            intTotalWeight.Value = totalWeight;
        }
    }
}
