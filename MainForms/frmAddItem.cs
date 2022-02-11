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
    public partial class frmAddItem : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int groupId = 0;
        public static int itemId = 0;
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            loadAgain();
        }
        private void loadAgain()
        {
            try
            {
                bsGroup.DataSource = db.FillItemGroup();
                if (IsEdit)
                {
                    bsItem.DataSource = db.FillItemsById(itemId);
                    cmbGroup.SelectedValue = groupId;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(cmbGroup, "نام کالا الزامی است");
                    txtName.Focus();
                }
                else if (string.IsNullOrEmpty(cmbGroup.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbGroup, "یک دسته بندی را انتخاب کنید");
                    cmbGroup.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsItem.EndEdit();
                        db.UpdateItems(itemId, (int)cmbGroup.SelectedValue, txtName.Text.Trim());
                    }
                    else
                    {
                        db.InsertItems((int)cmbGroup.SelectedValue,txtName.Text.Trim());
                        clearAll();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void clearAll()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtName.Focus();
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
