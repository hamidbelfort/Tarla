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
    public partial class frmShowBuyItem : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public frmShowBuyItem()
        {
            InitializeComponent();
        }

        private void frmShowBuyItem_Load(object sender, EventArgs e)
        {
            mskDate1.Text = pd.getShortDate();
            mskDate2.Text = pd.getShortDate();
            loadAgain();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuyItem.IsEdit = false;

                new frmBuyItem().ShowDialog();

                loadAgain();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
                loadAgain();
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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBuyItem((int)dgvBuy.CurrentRow.Cells[0].Value);
                    loadAgain();
                }
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

        private void mskDate1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void mskDate2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAgain();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
        private void loadAgain()
        {
            try
            {
                
                bsBuy.DataSource = db.FillBuyItembyDate(mskDate1.Text, mskDate2.Text);
                if (dgvBuy.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }
    }
}
