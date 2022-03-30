using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Tarla.Classes;
using BehComponents;
using Stimulsoft.Report;
using Tarla.MainForms;
namespace Tarla.OperationForms
{
    public partial class frmAddFactor : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int totalPrice, totalWeight;
        int totalCost;
        int profit, loss;
        int netSell, netPrice;
        int discount;
        int workersCost, workersCount;
        int miscCost;
        int truckRental;
        int? lastFactorId;
        string settingCompany, settingsAddress, settingsPhone;
        bool? existsMessage;

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
                else if(intLoss.Value==0)
                {
                    loss = 0;
                }
                else
                {
                    if (dgvFactor.Rows.Count > 0)
                    {
                        int index = -1;
                        for (int i = 0; i < dgvFactor.Rows.Count; i++)
                        {
                            int currentProduct = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmProductId"].Value.ToString());
                            int currentSellerId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmSellerId"].Value.ToString());
                            if (currentProduct == Convert.ToInt32(cmbProduct.SelectedValue.ToString()) &&
                                 currentSellerId == Convert.ToInt32(cmbSeller.SelectedValue.ToString()))
                            {
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            dgvFactor.Rows[index].Cells["clmQty"].Value = intCount.Value;
                            dgvFactor.Rows[index].Cells["clmWeight"].Value = intWeight.Value;
                            dgvFactor.Rows[index].Cells["clmPrice"].Value = intPrice.Value;
                            dgvFactor.Rows[index].Cells["clmSellerId"].Value = cmbSeller.SelectedValue;
                            dgvFactor.Rows[index].Cells["clmPackingId"].Value = cmbPacking.SelectedValue;
                            dgvFactor.Rows[index].Cells["clmLoss"].Value = intLoss.Value;
                            dgvFactor.Rows[index].Cells["clmPackingName"].Value = cmbPacking.Text;
                            dgvFactor.Rows[index].Cells["clmSellerName"].Value = cmbSeller.Text;
                        }
                        else
                        {
                            dgvFactor.Rows.Add(cmbProduct.Text, intPrice.Text, intCount.Text, intWeight.Text, intLoss.Text, cmbSeller.Text, cmbPacking.Text, cmbProduct.SelectedValue, cmbSeller.SelectedValue, cmbPacking.SelectedValue);

                        }
                    }
                    else
                    {
                        dgvFactor.Rows.Add(cmbProduct.Text, intPrice.Text, intCount.Text, intWeight.Text, intLoss.Text, cmbSeller.Text, cmbPacking.Text, cmbProduct.SelectedValue, cmbSeller.SelectedValue, cmbPacking.SelectedValue);

                    }
                    calculateTotalPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFactor.Rows.Count>0)
            {
                if (MessageBoxFarsi.Show("آیا از حذف این سطر اطمینان دارید؟","حذف",MessageBoxFarsiButtons.YesNo,MessageBoxFarsiIcon.Question)==DialogResult.Yes)
                {
                    dgvFactor.Rows.RemoveAt(dgvFactor.CurrentRow.Index);
                    calculateTotalPrice();
                }
            }
        }
        private void calculateProfitLoss()
        {
            int result = 0;
            if (netSell > 0)
            {
                result = Util.removeThousandSeprator(txtTotalProducts.Text) - netSell;
                if (result < 0)
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
            if (dgvFactor.Rows.Count > 0)
            {
                for (int i = 0; i < dgvFactor.Rows.Count; i++)
                {
                    int _weight = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString());
                    int _price = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPrice"].Value.ToString());
                    int _loss = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmLoss"].Value.ToString());
                    totalPrice += (_weight - _loss) * (_price);
                    totalWeight += (_weight) - (_loss);
                }
            }
            else
            {
                totalPrice = 0;
                totalWeight = 0;
            }
            lblTotalPrice.Text = totalPrice.ToString("N0");
            txtTotalWeight.Text = totalWeight.ToString("N0");
            intCount.Value = 0;
            intWeight.Value = 0;
            intPrice.Value = 0;
            intLoss.Value = 0;
            cmbProduct.Focus();
        }

        private void intWorkerCost_ValueChanged(object sender, EventArgs e)
        {
            if (intWorkerCost.Value > 0)
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
            if (intNetSell.Value > 0)
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
            if (intDiscount.Value > 0)
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
                    db.InsertInvoice(txtDate.Text, (int)cmbBuyer.SelectedValue,(int)cmbDriver.SelectedValue , totalWeight, intWorkersCount.Value,
                        intWorkerCost.Value, intTruckRental.Value, intMiscCost.Value, txtWeightNote.Text, txtDockWeightNote.Text,
                        (int)cmbBandarReceiver.SelectedValue, (int)cmbDubaiReceiver.SelectedValue, intDiscount.Value, totalPrice, intNetSell.Value,
                        intPaid.Value, int.Parse(txtProfit.Text), int.Parse(txtLoss.Text), txtDesc.Text);
                    db.GetMaxFactorId(ref lastFactorId);
                    for (int i = 0; i < dgvFactor.Rows.Count; i++)
                    {
                        int _productId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmProductId"].Value.ToString());
                        int _sellerId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmSellerId"].Value.ToString());
                        int _packId = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPackingId"].Value.ToString());
                        int _weight = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmWeight"].Value.ToString());
                        int _price = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmPrice"].Value.ToString());
                        int _qty = Convert.ToInt32(dgvFactor.Rows[i].Cells["clmQty"].Value.ToString());
                        int _loss=Convert.ToInt32(dgvFactor.Rows[i].Cells["clmLoss"].Value.ToString());
                        db.InsertInvoiceDetails(lastFactorId, _productId, _sellerId, _packId, _weight, _loss, _qty, _price, (_weight - _loss));
                    }
                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    btnSave.Enabled = false;
                    btnFactor.Enabled = true;
                    btnBook.Enabled = true;
                    btnAddNetSell.Enabled = true;
                    clearAll();
                }
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n"+ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void clearAll()
        {
            dgvFactor.Rows.Clear();
            totalCost = 0;
            totalPrice = 0;
            totalWeight = 0;
            txtTotalProducts.Clear();
            txtDate.Text = pd.getShortDate();
            txtDesc.Clear();
            txtDockWeightNote.Clear();
            txtLoss.Clear();
            txtNetPrice.Clear();
            txtProfit.Clear();
            txtTotalCost.Clear();
            txtTotalProducts.Clear();
            txtTotalWeight.Clear();
            txtWeightNote.Clear();
        }

        private void btnAddNetSell_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNetSell.invoiceId = (int)lastFactorId;
                new frmAddNetSell().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                db.GetAddressSetting(ref settingCompany, ref settingsAddress, ref settingsPhone);
                db.ExistsMessage(ref existsMessage);

                report.Load("Reports/rptFactor.mrt");
                report.Compile();

                report["invoiceId"] = lastFactorId;
                report["companyName"] = settingCompany;
                report["strAddress"] = settingsAddress;
                report["strPhone"] = settingsPhone;
                if (existsMessage == true)
                {
                    db.GetRandomMessage(ref message);
                    report["strMessage"] = message;
                }
                else
                {
                    report["strMessage"] = string.Empty;
                }
                report.ShowWithRibbonGUI();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void intWorkersCount_ValueChanged(object sender, EventArgs e)
        {
            if (intWorkersCount.Value > 0)
            {
                workersCount = intWorkersCount.Value;
            }
            else
            {
                workersCount = 0;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmAddBook.IsEdit = false;
            new frmAddBook().ShowDialog();
        }

        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int driverId = (int)cmbDriver.SelectedValue;
                string licensePlate = string.Empty;
                db.GetDriverLicensePlate(driverId,ref licensePlate);
                lblLicensePlate.Text = licensePlate;
            }
             catch
            {
                lblLicensePlate.Text = "-خطا-";
                //MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void radialMenu_ItemClick(object sender, EventArgs e)
        {
            RadialMenuItem item = sender as RadialMenuItem;
            if (item != null && !string.IsNullOrEmpty(item.Text))
            {
                switch (item.Name)
                {
                    case "mnuRefresh":
                        refresh();
                        break;
                    case "mnuReset":
                        reset();
                        break;
                    case "mnuDriver":
                        frmAddDriver.IsEdit = false;
                        new frmAddDriver().ShowDialog();
                        refresh(5);
                        break;
                    case "mnuReceiver":
                        frmAddPerson.IsEdit = false;
                        frmAddPerson.personType = 3;//receiver
                        new frmAddPerson().ShowDialog();
                        refresh(3);
                        break;
                    case "mnuSeller":
                        frmAddPerson.IsEdit = false;
                        frmAddPerson.personType = 2;//seller
                        new frmAddPerson().ShowDialog();
                        refresh(2);
                        break;
                    case "mnuBuyer":
                        frmAddPerson.IsEdit = false;
                        frmAddPerson.personType = 1;//buyer
                        new frmAddPerson().ShowDialog();
                        refresh(1);
                        break;
                    /*case "mnuFReceiver":
                        frmAddForeignReceiver.IsEdit = false;
                        new frmAddForeignReceiver().ShowDialog();
                        refresh(4);
                        break;*/
                    case "mnuProduct":
                        frmAddPacking.IsEdit = false;
                        new frmAddPacking().ShowDialog();
                        refresh(7);
                        break;
                    case "mnuPacking":
                        frmAddProduct.IsEdit = false;
                        new frmAddProduct().ShowDialog();
                        refresh(6);
                        break;
                }
            }
        }
        private void refresh()
        {
            try
            {
                //bsBuyer.DataSource = db.FillBuyer();
                //bsPacking.DataSource = db.FillPacking();
                bsProduct.DataSource = db.FillProducts();
                //bsReceiver.DataSource = db.FillReceiver();
                //bsSeller.DataSource = db.FillSeller();
                bsDriver.DataSource = db.FillDrivers();
                //bsF_Receiver.DataSource = db.FillForeignReceiver();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whichOne"> 
        /// 1:buyer
        /// 2:seller
        /// 3:receiver
        /// 4:foriegnReceiver
        /// 5:driver
        /// 6:product
        /// 7:packing
        /// </param>
        private void refresh(int whichOne)
        {
            try
            {
                switch (whichOne)
                {
                    case 1:
                        //bsBuyer.DataSource = db.FillBuyer();
                        break;
                    case 2:
                        //bsSeller.DataSource = db.FillSeller();
                        break;
                    case 3:
                        //bsReceiver.DataSource = db.FillReceiver();
                        break;
                    case 4:
                        //bsF_Receiver.DataSource = db.FillForeignReceiver();
                        break;
                    case 5:
                        bsDriver.DataSource = db.FillDrivers();
                        break;
                    case 6:
                        bsProduct.DataSource = db.FillProducts();
                        break;
                    case 7:
                        //bsPacking.DataSource = db.FillPacking();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void reset()
        {
            foreach(Control ctr in groupPanel2.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
            }
            totalCost = 0;
            totalPrice = 0;
            totalWeight = 0;
            profit = 0;
            loss = 0;
            lastFactorId = 0;
            btnSave.Enabled = true;
            btnFactor.Enabled = false;
            btnBook.Enabled = false;
            btnAddNetSell.Enabled = false;
            intCount.Value = 0;
            intDiscount.Value = 0;
            intPaid.Value = 0;
            intPrice.Value = 0;
            intWeight.Value = 0;
            intWorkerCost.Value = 0;
            intWorkersCount.Value = 0;
            intMiscCost.Value = 0;
            intNetSell.Value = 0;
            intTruckRental.Value = 0;
            lblCountry.Text = "---";
            lblLicensePlate.Text = "---";
            lblTotalPrice.Text = "0";
            dgvFactor.Rows.Clear();
            txtDate.Text = pd.getShortDate();
            txtContainerNo.Text = string.Empty;
            txtDate.Focus();
        }

        private void cmbDubaiReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int f_receiverId = (int)cmbDubaiReceiver.SelectedValue;
                string f_country = string.Empty;
                //db.GetForiegnReceiverCountry(f_receiverId, ref f_country);
                lblCountry.Text = string.Format("کشور : {0}",f_country);
            }
            catch
            {
                lblLicensePlate.Text = "-خطا-";
                //MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        string message;
        public frmAddFactor()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab == superTabItem1)
            {
                if (cmbBuyer.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbBuyer, "خریدار را انتخاب کنید");
                    cmbBuyer.Focus();
                }
                else if (cmbDriver.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbDriver, "راننده را انتخاب کنید");
                    cmbDriver.Focus();
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
                else if (dgvFactor.Rows.Count == 0)
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
            if (superTabControl1.SelectedTab == superTabItem2)
            {
                superTabControl1.SelectedTab = superTabItem1;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text = pd.getShortDate();
            superTabControl1.SelectedTab = superTabItem1;
            refresh();
        }

        
    }
}