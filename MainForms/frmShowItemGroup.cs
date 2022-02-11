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
using DevComponents.DotNetBar;

namespace Tarla.MainForms
{
    public partial class frmShowItemGroup : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int groupId = 0;
        public frmShowItemGroup()
        {
            InitializeComponent();
        }

        private void frmShowItemGroup_Load(object sender, EventArgs e)
        {
            loadAgain();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddItemGroup.IsEdit = false;

                new frmAddItemGroup().ShowDialog();

                loadAgain();
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
                frmAddItemGroup.IsEdit = true;

                frmAddItemGroup.groupId = (int)dgvGroup.CurrentRow.Cells[0].Value;

                new frmAddItemGroup().ShowDialog();

                db = new dcTarlaDataContext();
                loadAgain();
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
                    db.DeleteItemGroup((int)dgvGroup.CurrentRow.Cells[0].Value);
                    loadAgain();
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
        private void loadAgain()
        {
            try
            {
                bsGroup.DataSource = db.FillItemGroup();
                if (dgvGroup.Rows.Count == 0)
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
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
                        loadAgain();
                        break;
                }
            }
        }
    }
}
