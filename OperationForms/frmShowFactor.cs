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
using Stimulsoft.Report;
namespace Tarla.OperationForms
{
    public partial class frmShowFactor : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int sumTotalPrice, sumNetSell;
        string settingCompany,settingsAddress, settingsPhone;
        string buyerName, buyerPhone;
        bool? existsMessage;
        int invoiceId;
        string message;
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
                frmInvoiceDetails.invoiceId = (int)dgvFactor.CurrentRow.Cells[1].Value;
                new frmInvoiceDetails().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
                bsBuyer.DataSource = db.FillBuyer();
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
                    btnPrintFactor.Enabled = false;
                    btnNetSell.Enabled = false;
                    btnShow.Enabled = false;
                    lblSumTotalPrice.Text = "0";
                    lblSumNetSell.Text = "0";
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;
                    btnPrintFactor.Enabled = true;
                    btnNetSell.Enabled = true;
                    btnShow.Enabled = true;
                    calculateSum();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
        private void calculateSum()
        {
            sumNetSell = 0;
            sumTotalPrice = 0;
            for (int i = 0; i < dgvFactor.Rows.Count; i++)
            {
                sumTotalPrice += (int)dgvFactor.Rows[i].Cells[8].Value;
                sumNetSell += (int)dgvFactor.Rows[i].Cells[9].Value;
            }
            lblSumTotalPrice.Text = sumTotalPrice.ToString("N0");
            lblSumNetSell.Text = sumNetSell.ToString("N0");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                db.GetAddressSetting(ref settingCompany, ref settingsAddress, ref settingsPhone);

                if (rdoDate.Checked)
                {
                    report.Load("Reports/rptFactorListByDate.mrt");
                    report.Compile();

                    report["strDate1"] = mskDate1.Text;
                    report["strDate2"] = mskDate2.Text;
                    report["sumTotalPrice"] = sumTotalPrice;
                    report["sumNetSell"] = sumNetSell;
                    report["strAddress"] = settingsAddress;
                    report["strPhone"] = settingsPhone;
                }
                else if (rdoBuyer.Checked)
                {
                    int buyerId = (int)cmbBuyer.SelectedValue;
                    db.GetBuyerNameAndPhone(buyerId, ref buyerName, ref buyerPhone);
                    report.Load("Reports/rptFactorListById.mrt");
                    report.Compile();

                    report["buyerId"] = buyerId;
                    report["buyerName"] = buyerName;
                    report["buyerPhone"] = buyerPhone;
                    report["sumTotalPrice"] = sumTotalPrice;
                    report["sumNetSell"] = sumNetSell;
                    report["strAddress"] = settingsAddress;
                    report["strPhone"] = settingsPhone;
                }
                report.ShowWithRibbonGUI();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void dgvFactor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvFactor.Rows[e.RowIndex].Cells["clmRow"].Value = e.RowIndex + 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟\n"+"هشدار:این عملیات غیرقابل برگشت است!", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteInvoice((int)dgvFactor.CurrentRow.Cells[1].Value);
                    loadAgain(0, mskDate1.Text, mskDate2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
                frmAddNetSell.invoiceId = (int)dgvFactor.CurrentRow.Cells[1].Value;
                new frmAddNetSell().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPrintFactor_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                db.GetAddressSetting(ref settingCompany, ref settingsAddress, ref settingsPhone);
                db.ExistsMessage(ref existsMessage);
                invoiceId = (int)dgvFactor.CurrentRow.Cells[1].Value;


                report.Load("Reports/rptFactor.mrt");
                report.Compile();

                report["invoiceId"] = invoiceId;
                report["companyName"] = settingCompany;
                report["strAddress"] = settingsAddress;
                report["strPhone"] = settingsPhone;
                if (existsMessage==true)
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
                MessageBoxFarsi.Show("در تولید گزارش خطا رخ داده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
