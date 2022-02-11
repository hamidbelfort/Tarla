using BehComponents;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarla.MainForms
{
    public partial class frmShowProducts : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int productId = 0;
        public static int groupId = 0;
        public frmShowProducts()
        {
            InitializeComponent();
        }

        private void frmShowProducts_Load(object sender, EventArgs e)
        {
            try
            {
                cmbGroup.Enabled = false;
                chkGroup.Checked = false;
                bsProducts.DataSource = db.FilterProducts(txtFilter.Text);
                if (dgvProduct.Rows.Count == 0)
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

        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cmbGroup.Enabled = chkGroup.Checked;

                if (chkGroup.Checked)
                {
                    bsGroups.DataSource = db.FillGroups();

                    bsProducts.DataSource = db.FilterProductsByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProducts.DataSource = db.FilterProducts(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddProduct.IsEdit = false;

                new frmAddProduct().ShowDialog();

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
                frmAddProduct.IsEdit = true;

                frmAddProduct.productId = (int)dgvProduct.CurrentRow.Cells[0].Value;
                frmAddProduct.groupId = (int)dgvProduct.CurrentRow.Cells[1].Value;

                new frmAddProduct().ShowDialog();

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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این محصول هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteProducts((int)dgvProduct.CurrentRow.Cells[0].Value);
                    loadAgain();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void loadAgain()
        {
            try
            {
                if (chkGroup.Checked)
                {
                    bsGroups.DataSource = db.FillGroups();

                    bsProducts.DataSource = db.FilterProductsByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProducts.DataSource = db.FilterProducts(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            loadAgain();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bsProducts.DataSource = db.FilterProductsByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);

                if (dgvProduct.Rows.Count == 0)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
