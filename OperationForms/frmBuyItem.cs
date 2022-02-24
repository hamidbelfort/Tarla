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
using DevComponents.DotNetBar;
using Tarla.MainForms;

namespace Tarla.OperationForms
{
    public partial class frmBuyItem : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        /*public static bool IsEdit;
        public static int companyId = 0;
        public static int itemId = 0;
        public static int buyId = 0;*/
        int totalPrice,finalPrice;
        int discount, tax,serviceCost;
        int qty, itemPrice;
        int? depotId;
        int? lastFactorId;
        public frmBuyItem()
        {
            InitializeComponent();
        }

        private void frmBuyItem_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void clearAll()
        {
            txtDate.Text = pd.getShortDate();
            txtDesc.Clear();
            totalPrice = 0;
            discount = 0;
            tax = 0;
            serviceCost = 0;
            finalPrice = 0;
            itemPrice = 0;
            qty = 0;
            lblTotalPrice.Text = "0";
            dgvItems.Rows.Clear();
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
                intQty2.Value = intQty.Value;
                if (intQty.Value>0 && intPrice.Value>0)
                {
                    qty = intQty.Value;
                    calculateTotalPrice();
                }
            }
            catch
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab==superTabItem1)
            {
                if (cmbCompany.Text==string.Empty)
                {
                    errorProvider1.SetError(cmbCompany,"یک شرکت را انتخاب کنید");
                    cmbCompany.Focus();
                }
                else if(!chkDefaultDepot.Enabled && cmbDepot.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbDepot, "یک انبار را انتخاب کنید");
                    cmbCompany.Focus();
                }
                else if (txtDate.Text==string.Empty)
                {
                    errorProvider1.Clear();
                    txtDate.Text = pd.getShortDate();
                }
                else
                {
                    superTabControl1.SelectedTab = superTabItem2;
                    btnPrev.Enabled = true;
                }
            }
            else if (superTabControl1.SelectedTab == superTabItem2)
            {
                if (dgvItems.Rows.Count==0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbItem, "یک محصول را انتخاب کنید");
                    cmbItem.Focus();
                }
                else
                {
                    intTotalPrice.Value = totalPrice;
                    superTabControl1.SelectedTab = superTabItem3;
                    btnNext.Enabled = false;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab==superTabItem2)
            {
                superTabControl1.SelectedTab = superTabItem1;
                btnPrev.Enabled = false;
            }
            else if(superTabControl1.SelectedTab==superTabItem3)
            {
                superTabControl1.SelectedTab = superTabItem2;
                btnNext.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (intPrice.Value==0)
                {
                    errorProvider1.SetError(intPrice, "قیمت کالا را وارد کنید");
                }
                else if (intQty.Value==0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(intQty, "تعداد را وارد کنید");
                }
                else
                {
                    errorProvider1.Clear();
                    if (dgvItems.Rows.Count>0)
                    {
                        int index = -1;
                        for (int i = 0; i < dgvItems.Rows.Count; i++)
                        {
                            int currentItem = (int)(dgvItems.Rows[i].Cells["clmItemId"].Value);
                            if (currentItem == Convert.ToInt32(cmbItem.SelectedValue.ToString()))
                            {
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            dgvItems.Rows[index].Cells["clmQty"].Value = intQty.Value;
                            dgvItems.Rows[index].Cells["clmPrice"].Value = intPrice.Value;
                            calculateTotalPrice();
                            cmbItem.Focus();
                        }
                        else
                        {
                            dgvItems.Rows.Add(null, cmbItem.SelectedValue, cmbItem.Text, intPrice.Value, intQty.Value);
                            cmbItem.Focus();
                        }
                    }
                    else
                    {
                        dgvItems.Rows.Add(null, cmbItem.SelectedValue, cmbItem.Text, intPrice.Value, intQty.Value);
                        cmbItem.Focus();
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
            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index);
                calculateTotalPrice();
            }
        }

        private void chkDefaultDepot_CheckedChanged(object sender, EventArgs e)
        {
            cmbDepot.Enabled = !chkDefaultDepot.Checked;
        }

        private void intTaxCost_ValueChanged(object sender, EventArgs e)
        {
            if (intTaxCost.Value>0)
            {
                tax = intTaxCost.Value;
                
            }
            else
            {
                tax = 0;
            }
            calculateFinalPrice();
        }

        private void intServiceCost_ValueChanged(object sender, EventArgs e)
        {
            if (intServiceCost.Value > 0)
            {
                serviceCost = intServiceCost.Value;

            }
            else
            {
                serviceCost = 0;
            }
            calculateFinalPrice();
        }

        private void intDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (intDiscount.Value > 0)
            {
                discount = intServiceCost.Value;

            }
            else
            {
                discount = 0;
            }
            calculateFinalPrice();
        }

        private void intPrice_ValueChanged(object sender, EventArgs e)
        {
            if (intPrice.Value>0)
            {
                itemPrice = intPrice.Value;
                if (intQty.Value>0)
                {
                    qty = intQty.Value;
                    calculateTotalPrice();
                }
            }
            else
            {
                itemPrice = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا از ثبت و ذخیره اطلاعات فاکتور اطمینان دارید؟", "ذخیره فاکتور", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Information) == DialogResult.Yes)
                {
                    db.InsertBuyFactor(txtDate.Text, txtFactorNumber.Text, (int)cmbCompany.SelectedValue, totalPrice, discount, tax, serviceCost, finalPrice, txtDesc.Text);
                    db.GetMaxBuyFactorId(ref lastFactorId);
                    string stockDesc = string.Format("{0} : خرید با شماره فاکتور", txtFactorNumber.Text);
                    for (int i = 0; i < dgvItems.Rows.Count; i++)
                    {
                        int _itemId = Convert.ToInt32(dgvItems.Rows[i].Cells["clmItemId"].Value.ToString());
                        int _qty = Convert.ToInt32(dgvItems.Rows[i].Cells["clmQty"].Value.ToString());
                        int _price = Convert.ToInt32(dgvItems.Rows[i].Cells["clmPrice"].Value.ToString());
                        db.InsertBuyDetail(lastFactorId, _itemId, _price, _qty);
                        db.InsertStock(txtDate.Text, lastFactorId, depotId, _itemId, _qty, 0, stockDesc);
                    }
                    
                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    btnSave.Enabled = false;
                    btnFactor.Enabled = true;
                    btnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
                        clearAll();
                        break;
                    case "mnuDepot":
                        frmAddDepot.IsEdit = false;
                        new frmAddDepot().ShowDialog();
                        refresh(2);
                        break;
                    case "mnuCompany":
                        frmAddCompany.IsEdit = false;
                        new frmAddCompany().ShowDialog();
                        refresh(1);
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whichOne">
        /// 1:Company
        /// 2:Depot
        /// </param>
        private void refresh(int whichOne)
        {
            try
            {
                switch (whichOne)
                {
                    case 1:
                        bsCompany.DataSource = db.FillCompany();
                        break;
                    case 2:
                        bsDepot.DataSource = db.FillDepot();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void refresh()
        {
            try
            {
                superTabControl1.SelectedTab = superTabItem1;
                bsStock.DataSource = db.FillItems();
                bsCompany.DataSource = db.FillCompany();
                bsDepot.DataSource = db.FillDepot();
                chkDefaultDepot.Enabled = true;
                cmbDepot.Enabled = !chkDefaultDepot.Checked;
                txtDate.Text = pd.getShortDate();
                db.GetDefaultDepot(ref depotId);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvItems.Rows[e.RowIndex].Cells["clmRow"].Value = e.RowIndex + 1;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItem.SelectedIndex >= 0)
                {
                    int itemId = (int)(cmbItem.SelectedValue);
                    var temp = db.FillViewStockByItem(itemId).ToList();
                    lblBalance.Text = temp[0].StockBalance.ToString();
                    lblUnit.Text= temp[0].Unit1.ToString();
                    lblUnit2.Text = temp[0].Unit2.ToString();
                }
            }
            catch
            {
            }
        }
        private void calculateFinalPrice()
        {
            try
            {
                finalPrice = (totalPrice + tax + serviceCost) - discount;
                intFinalPrice.Value = finalPrice;
            }
            catch
            {
                finalPrice = 0;
                intFinalPrice.Value = finalPrice;
            }
           
        }
        private void calculateTotalPrice()
        {
            try
            {
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    int qty = (int)(dgvItems.Rows[i].Cells["clmQty"].Value);
                    int price = (int)(dgvItems.Rows[i].Cells["clmPrice"].Value);
                    totalPrice += (qty * price);
                }
                lblTotalPrice.Text = totalPrice.ToString("N0");
            }
            catch
            {
                lblTotalPrice.Text = "0";
            }
            
        }
    }
}
