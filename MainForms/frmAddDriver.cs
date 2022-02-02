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
    public partial class frmAddDriver : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int driverId = 0;
        public static bool IsEdit;
        public frmAddDriver()
        {
            InitializeComponent();
        }

        private void frmAddDriver_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsDriver.DataSource = db.FillDriverById(driverId);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام راننده الزامی است");
                    txtName.Focus();
                }
                else if (string.IsNullOrEmpty(txtLicensePlate.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtLicensePlate, "شماره پلاک کامیون الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsDriver.EndEdit();
                        db.UpdateDriver(driverId, txtName.Text, txtLicenseId.Text, txtLicensePlate.Text, txtPhone.Text, txtAddress.Text);
                    }
                    else
                    {
                        db.InsertDriver(txtName.Text, txtLicenseId.Text, txtLicensePlate.Text, txtPhone.Text, txtAddress.Text);
                        clearAll();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
        private void clearAll()
        {
            txtLicenseId.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtName.Clear();
            txtAddress.Clear();
            txtLicensePlate.Clear();
            txtName.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}