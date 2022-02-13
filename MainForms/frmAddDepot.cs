using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BehComponents;

namespace Tarla.MainForms
{
    public partial class frmAddDepot : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int depotId=0;
        public frmAddDepot()
        {
            InitializeComponent();
        }

        private void frmAddDepot_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsDepot.DataSource = db.FillDepotById(depotId);
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
                    errorProvider1.SetError(txtName, "نام انبار الزامی است");
                    txtName.Focus();
                }
                else
                {
                    if (IsEdit)
                    {
                        bsDepot.EndEdit();
                        db.UpdateDepot(depotId, txtName.Text);
                    }
                    else
                    {
                        db.InsertDepot(txtName.Text);
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
            Close();
        }
        private void clearAll()
        {
            txtName.Clear();
            txtName.Focus();
        }
    }
}