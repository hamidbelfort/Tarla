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
using Tarla.Classes;
namespace Tarla.OperationForms
{
    public partial class frmShowFactor : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public frmShowFactor()
        {
            InitializeComponent();
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = true;
            mskDate2.Enabled = true;
            cmbBuyer.Enabled = false;
        }

        private void rdoBuyer_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = false;
            mskDate2.Enabled = false;
            cmbBuyer.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoiceDetails.invoiceId = (int)dgvFactor.CurrentRow.Cells[0].Value;
                new frmInvoiceDetails().ShowDialog();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            } 
        }

        private void cmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain((int)cmbBuyer.SelectedValue,string.Empty, string.Empty);
            }
            catch
            {
                
            }
        }

        private void mskDate2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch
            {

            }
            
        }

        private void mskDate1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch
            {

            }
            
        }
        private void loadAgain(int buyerId,string date1,string date2)
        {
            try
            {
                if (date1!=string.Empty && date2!=string.Empty)
                {
                    bsInvoiceView.DataSource = db.FilterFactorByDate(mskDate1.Text, mskDate2.Text);
                }
                else if (buyerId != 0)
                {
                    bsInvoiceView.DataSource = db.FilterFactorById(buyerId);
                }
                if (dgvFactor.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnShow.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;
                    btnShow.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟\n"+"هشدار:این عملیات غیرقابل برگشت است!", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteInvoice((int)dgvFactor.CurrentRow.Cells[0].Value);
                    loadAgain(0, mskDate1.Text, mskDate2.Text);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frmShowFactor_Load(object sender, EventArgs e)
        {
            mskDate1.Text = pd.getShortDate();
            mskDate2.Text = pd.getShortDate();
            loadAgain(0, mskDate1.Text, mskDate2.Text);
        }

        private void btnNetSell_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNetSell.invoiceId = (int)dgvFactor.CurrentRow.Cells[0].Value;
                new frmAddNetSell().ShowDialog();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
