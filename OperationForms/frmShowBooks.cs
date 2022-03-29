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
    public partial class frmShowBooks : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int sumAmount = 0;
        public frmShowBooks()
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

        private void frmShowBooks_Load(object sender, EventArgs e)
        {
            mskDate1.Text = pd.getShortDate();
            mskDate2.Text = pd.getShortDate();
            rdoDate.Checked = true;
            rdoBuyer.Checked = false;
            cmbBuyer.Enabled = false;
            loadAgain(0, mskDate1.Text, mskDate2.Text);
        }

        private void cmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain((int)cmbBuyer.SelectedValue, string.Empty, string.Empty);
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
        private void loadAgain(int buyerId, string date1, string date2)
        {
            try
            {
                //cmbBuyer.DataSource = db.FillBuyer();
                if (date1 != string.Empty && date2 != string.Empty)
                {
                    bsBook.DataSource = db.FilterBooksViewByDate(mskDate1.Text, mskDate2.Text);
                }
                else if (buyerId != 0)
                {
                    bsBook.DataSource = db.FilterBooksViewById(buyerId);
                }
                if (dgvBook.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    lblSumAmount.Text = "0";
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;
                    calculateSum();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
        private void calculateSum()
        {
            sumAmount = 0;
            for (int i = 0; i < dgvBook.Rows.Count; i++)
            {
                sumAmount += (int)dgvBook.Rows[i].Cells[4].Value;
            }
            lblSumAmount.Text = sumAmount.ToString("N0");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddBook.IsEdit = true;
                frmAddBook.bookId = (int)dgvBook.CurrentRow.Cells[0].Value;
                frmAddBook.buyerId = (int)dgvBook.CurrentRow.Cells[2].Value;
                new frmAddBook().ShowDialog();

                db = new dcTarlaDataContext();
                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBook((int)dgvBook.CurrentRow.Cells[0].Value);
                    loadAgain(0, mskDate1.Text, mskDate2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddBook.IsEdit = false;

                new frmAddBook().ShowDialog();

                loadAgain(0,mskDate1.Text,mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                
                StiReport report = new StiReport();
                if (rdoDate.Checked)
                {
                    report.Load("Reports/rptBookByDate.mrt");
                    report.Compile();

                    report["strDate1"] = mskDate1.Text;
                    report["strDate2"] = mskDate2.Text;
                    report["sumAmount"] = sumAmount;

                }
                else if (rdoBuyer.Checked)
                {
                    report.Load("Reports/rptBookById.mrt");
                    report.Compile();

                    report["buyerId"] = mskDate1.Text;
                    report["sumAmount"] = sumAmount;
                }
                report.ShowWithRibbonGUI();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("در تولید گزارش خطا رخ داده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
