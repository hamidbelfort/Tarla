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
    public partial class frmInvoiceDetails : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int invoiceId = 0;
        int totalWeight, totalPrice;
        public frmInvoiceDetails()
        {
            InitializeComponent();
        }

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            try
            {
                bsDetails.DataSource = db.GetInvoiceDetails(invoiceId);
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    int _weight = Convert.ToInt32(dgvDetails.Rows[i].Cells[5].Value.ToString());
                    int _price = Convert.ToInt32(dgvDetails.Rows[i].Cells[7].Value.ToString());
                    totalWeight += _weight;
                    totalPrice += _weight * _price;
                }
                lblTotalWeight.Text = totalWeight.ToString("N0");
                lblTotalPrice.Text = totalPrice.ToString("N0");
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
    }
}
