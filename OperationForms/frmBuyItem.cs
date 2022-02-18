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
    public partial class frmBuyItem : DevComponents.DotNetBar.OfficeForm
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
                bsStock.DataSource = db.FillItems();
                bsCompany.DataSource = db.FillCompany();
                bsDepot.DataSource = db.FillDepot();
                chkDefaultDepot.Enabled = true;
                cmbDepot.Enabled = chkDefaultDepot.Checked;
                if (IsEdit)
                {
                    //bsBuy.DataSource = db.FillBuyItemById(buyId);
                    cmbCompany.SelectedValue = companyId;
                    cmbItem.SelectedValue = itemId;
                }
                else
                {
                    txtDate.Text = pd.getShortDate();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
                 totalPrice = 0;
                lblTotalPrice.Text = totalPrice.ToString("N0");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

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
    }
}
