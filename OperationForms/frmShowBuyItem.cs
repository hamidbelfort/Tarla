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
using Stimulsoft.Report;
namespace Tarla.OperationForms
{
    public partial class frmShowBuyItem : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int sumPrice;
        int searchMode;
        public frmShowBuyItem()
        {
            InitializeComponent();
        }

        private void frmShowBuyItem_Load(object sender, EventArgs e)
        {
            try
            {
                mskDate1.Text = pd.getShortDate();
                mskDate2.Text = pd.getShortDate();
                bsCompany.DataSource = db.FillCompany();
                rdoDate.Checked = true;
                rdoCompany.Checked = false;
                cmbCompany.Enabled = false;
                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuyItem.IsEdit = false;

                new frmBuyItem().ShowDialog();

                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuyItem.IsEdit = true;

                frmBuyItem.buyId = (int)dgvBuy.CurrentRow.Cells[0].Value;
                frmBuyItem.itemId = (int)dgvBuy.CurrentRow.Cells[1].Value;
                frmBuyItem.companyId = (int)dgvBuy.CurrentRow.Cells[2].Value;

                new frmBuyItem().ShowDialog();

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
                    db.DeleteBuyItem((int)dgvBuy.CurrentRow.Cells[0].Value);
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

        private void mskDate1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain(0,mskDate1.Text,mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void mskDate2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain(0, mskDate1.Text, mskDate2.Text);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
        private void loadAgain(int companyId,string date1,string date2)
        {
            try
            {
                
                if (date1 != string.Empty && date2 != string.Empty)
                {
                    bsBuy.DataSource = db.FillBuyItembyDate(mskDate1.Text, mskDate2.Text);
                }
                else if (companyId != 0)
                {
                    bsBuy.DataSource = db.FillBuyItemByCompany(companyId);
                }
                if (dgvBuy.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnPrint.Enabled = false;
                    lblSumAmount.Text = "0";
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
            sumPrice = 0;
            for (int i = 0; i < dgvBuy.Rows.Count; i++)
            {
                sumPrice += (int)dgvBuy.Rows[i].Cells[9].Value;
            }
            lblSumAmount.Text = sumPrice.ToString("N0");
        }
        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = true;
            mskDate2.Enabled = true;
            cmbCompany.Enabled = false;
        }

        private void rdoCompany_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = false;
            mskDate2.Enabled = false;
            cmbCompany.Enabled = true;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain((int)cmbCompany.SelectedValue,string.Empty, string.Empty);
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                if (rdoDate.Checked)
                {
                    report.Load("Reports/rptBuyItemByDate.mrt");
                    report.Compile();

                    report["strDate1"] = mskDate1.Text;
                    report["strDate2"] = mskDate2.Text;
                    report["sumTotalPrice"] = sumPrice;
                    
                }
                else if(rdoCompany.Checked)
                {
                    report.Load("Reports/rptBuyItemById.mrt");
                    report.Compile();

                    report["companyId"] = mskDate1.Text;
                    report["sumTotalPrice"] = sumPrice;
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
