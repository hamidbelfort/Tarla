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

namespace Tarla.MainForms
{
    public partial class frmAddItemGroup : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int groupId = 0;
        public frmAddItemGroup()
        {
            InitializeComponent();
        }

        private void frmAddItemGroup_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsGroup.DataSource = db.FillItemGroupById(groupId);
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
                    errorProvider1.SetError(txtName, "نام گروه الزامی است");
                    txtName.Focus();
                }
                else if (string.IsNullOrEmpty(txtUnit1.Text))
                {
                    errorProvider1.SetError(txtUnit1, "نام واحد اول الزامی است");
                    txtUnit1.Focus();
                }
                else if (string.IsNullOrEmpty(txtUnit2.Text))
                {
                    errorProvider1.SetError(txtUnit2, "نام واحد دوم الزامی است");
                    txtUnit2.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsGroup.EndEdit();
                        db.UpdateItemGroup(groupId, txtName.Text, txtUnit1.Text, txtUnit2.Text);
                    }
                    else
                    {
                        db.InsertItemGroup(txtName.Text, txtUnit1.Text, txtUnit2.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearAll()
        {
            txtName.Clear();
            txtUnit1.Focus();
            txtUnit2.Focus();
        }
    }
}
