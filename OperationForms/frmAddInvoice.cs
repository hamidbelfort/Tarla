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
using BehComponents;
namespace Tarla.OperationForms
{
    public partial class frmAddInvoice : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int totalPrice, totalWeight;
        int totalCost;
        int profit, loss;
        int netSell,netPrice;
        int discount;
        int workersCost,workersCount;
        int miscCost;
        int truckRental;
        int? lastFactorId;
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
                else if (txtLicensePlate.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtLicensePlate, "شماره پلاک کامیون را انتخاب کنید");
                    txtLicensePlate.Focus();
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
                else if (dgvFactor.Rows.Count==0)
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
                    superTabControl1.SelectedTab = superTabItem2;
                    btnNext.Enabled = false;
                    btnPrev.Enabled = true;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab==superTabItem2)
            {
                superTabControl1.SelectedTab = superTabItem1;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text = pd.getShortDate();
            bsBuyer.DataSource = db.FillBuyer();
            bsPacking.DataSource = db.FillPacking();
            bsProduct.DataSource = db.FillProducts();
            bsReceiver.DataSource = db.FillReceiver();
            bsSeller.DataSource = db.FillSeller();
            bsF_Receiver.DataSource = db.FillForeignReceiver();
            superTabControl1.SelectedTab = superTabItem1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (intCount.Value == 0)
                {
                    errorProvider1.SetError(intCount, "تعداد را وارد کنید");
                    intCount.Focus();
                }
                else if (intWeight.Value == 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(intWeight, "وزن را وارد کنید");
                    intWeight.Focus();
                }
                else if (intPrice.Value == 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(intPrice, "قیمت را وارد کنید");
                    intPrice.Focus();
                }
                else
                {
                    if (dgvFactor.Rows.Count == 0)
                    {
                        dgvFactor.Rows.Add(cmbProduct.Text, intPrice.Text, intCount.Text, intWeight.Text, cmbSeller.Text, cmbPacking.Text, cmbProduct.SelectedValue, cmbSeller.SelectedValue, cmbPacking.SelectedValue);
                    }
                    else
                    {
                        for (int i = 0; i < dgvFactor.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmProduct"].Value.ToString()) == Convert.ToInt32(cmbProduct.SelectedValue.ToString()))
                            {
                                dgvFactor.Rows[i].Cells["clmQty"].Value = intCount.Value;
                                dgvFactor.Rows[i].Cells["clmWeight"].Value = intWeight.Value;
                                dgvFactor.Rows[i].Cells["clmPrice"].Value = intPrice.Value;
                                dgvFactor.Rows[i].Cells["clmSeller"].Value = cmbSeller.SelectedValue;
                                dgvFactor.Rows[i].Cells["clmPacking"].Value = cmbPacking.SelectedValue;
                                dgvFactor.Rows[i].Cells["clmPackingName"].Value = cmbPacking.Text;
                                dgvFactor.Rows[i].Cells["clmSellerName"].Value = cmbSeller.Text;
                            }
                            else
                            {

                            }
                        }
                    }
                    calculateTotalPrice();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvFactor.Rows.RemoveAt(dgvFactor.CurrentRow.Index);
            calculateTotalPrice();
        }

        private void intWorkerCost_ValueChanged(object sender, EventArgs e)
        {
            if (intWorkerCost.Value>0)
            {
                workersCost = intWorkerCost.Value;
            }
            else
            {
                workersCost = 0;
            }
            calculateTotalCosts();
        }

        private void intTruckRental_ValueChanged(object sender, EventArgs e)
        {
            if (intTruckRental.Value > 0)
            {
                truckRental = intTruckRental.Value;
            }
            else
            {
                truckRental = 0;
            }
            calculateTotalCosts();
        }

        private void intMiscCost_ValueChanged(object sender, EventArgs e)
        {
            if (intMiscCost.Value > 0)
            {
                miscCost = intMiscCost.Value;
            }
            else
            {
                miscCost = 0;
            }
            calculateTotalCosts();
        }

        private void intNetSell_ValueChanged(object sender, EventArgs e)
        {
            if (intNetSell.Value>0)
            {
                netSell = intNetSell.Value;
            }
            else
            {
                netSell = 0;
            }
            calculateProfitLoss();
        }

        private void intDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (intDiscount.Value>0)
            {
                discount = intDiscount.Value;
            }
            else
            {
                discount = 0;
            }
            calculateTotalCosts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا از ثبت و ذخیره اطلاعات فاکتور اطمینان دارید؟", "ذخیره فاکتور", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Information) == DialogResult.Yes)
                {
                    totalWeight = Util.removeThousandSeprator(txtTotalWeight.Text);
                    db.InsertInvoice(txtDate.Text, (int)cmbBuyer.SelectedValue, txtLicensePlate.Text, totalWeight, intWorkersCount.Value,
                        intWorkerCost.Value, intTruckRental.Value, intMiscCost.Value, txtWeightNote.Text, txtDockWeightNote.Text,
                        (int)cmbBandarReceiver.SelectedValue, (int)cmbDubaiReceiver.SelectedValue, intDiscount.Value, totalPrice, intNetSell.Value,
                        intPaid.Value, int.Parse(txtProfit.Text), int.Parse(txtLoss.Text), txtDesc.Text);
                    db.GetMaxFactorId(ref lastFactorId);
                    for (int i = 0; i < dgvFactor.Rows.Count; i++)
                    {
                        int _productId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmProduct"].Value.ToString());
                        int _sellerId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmSeller"].Value.ToString());
                        int _packId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPacking"].Value.ToString());
                        int _weight = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString());
                        int _price = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPrice"].Value.ToString());
                        int _qty = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmQty"].Value.ToString());
                        db.InsertInvoiceDetails(lastFactorId, _productId, _sellerId, _packId, _weight, _qty, _price);
                    }
                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    btnSave.Enabled = false;
                    btnFactor.Enabled = true;
                    btnBook.Enabled = true;
                    btnAddNetSell.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void btnAddNetSell_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNetSell.invoiceId = (int)lastFactorId;
                new frmAddNetSell().ShowDialog();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmAddBook.IsEdit = false;
            new frmAddBook().ShowDialog();
        }

        private void intWorkersCount_ValueChanged(object sender, EventArgs e)
        {
            if (intWorkersCount.Value>0)
            {
                workersCount = intWorkersCount.Value;
            }
            else
            {
                workersCount = 0;
            }
        }

        private void calculateProfitLoss()
        {
            int result=0;
            if (netSell>0)
            {
                result = Util.removeThousandSeprator(txtTotalProducts.Text) - netSell;
                if (result<0)
                {
                    profit = Math.Abs(result);
                    txtLoss.Text = "0";
                    txtProfit.Text = profit.ToString("N0");
                }
                else
                {
                    loss = result;
                    txtProfit.Text = "0";
                    txtLoss.Text = loss.ToString("N0");
                    
                }
            }
            else
            {
                profit = 0;
                loss = 0;
                txtProfit.Text = "0";
                txtLoss.Text = "0";
            }
        }
        private void calculateTotalCosts()
        {
            totalCost = (workersCost + truckRental + miscCost);
            txtTotalCost.Text = totalCost.ToString("N0");
            netPrice = Util.removeThousandSeprator(txtTotalProducts.Text) - discount;
            txtNetPrice.Text = netPrice.ToString("N0");
        }
        private void calculateTotalPrice()
        {
            totalPrice = 0;
            totalWeight = 0;
            if (dgvFactor.Rows.Count>0)
            {
                for (int i = 0; i < dgvFactor.Rows.Count; i++)
                {
                    totalPrice += (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString())) * (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPrice"].Value.ToString()));
                    totalWeight += (Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString()));
                }
            }
            else
            {
                totalPrice = 0;
                totalWeight = 0;
            }
            lblTotalPrice.Text = totalPrice.ToString("N0");
            txtTotalWeight.Text = totalWeight.ToString("N0");
        }
    }
}
