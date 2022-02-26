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

namespace Tarla.OperationForms
{
    public partial class frmBuyDetails : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int factorId;
        int totalPrice, totalQty;
        public frmBuyDetails()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvDetails.Rows[e.RowIndex].Cells["clmRow"].Value = e.RowIndex + 1;
        }

        private void frmBuyDetails_Load(object sender, EventArgs e)
        {
            try
            {
                bsBuyDetails.DataSource = db.FillBuyDetail(factorId);
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    int qty = (int)(dgvDetails.Rows[i].Cells[6].Value);
                    int price = (int)(dgvDetails.Rows[i].Cells[6].Value);
                    totalQty += qty;
                    totalPrice += (qty * price);
                }
                lblTotalPrice.Text = totalPrice.ToString("N0");
                lblTotalQty.Text = totalQty.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
