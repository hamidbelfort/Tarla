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

namespace Tarla.MainForms
{
    public partial class frmAddForeignReceiver : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int receiverId = 0;
        public static bool IsEdit;
        public frmAddForeignReceiver()
        {
            InitializeComponent();
        }

        private void frmAddForeignReceiver_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsReceiver.DataSource = db.FillForeignReceiverById(receiverId);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام گیرنده بار الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsReceiver.EndEdit();
                        db.UpdateForeignReceiver(receiverId, txtName.Text, txtPhone.Text, txtAddress.Text, txtCountry.Text, txtDesc.Text);
                    }
                    else
                    {
                        db.InsertForeignReceiver(txtName.Text, txtPhone.Text, txtAddress.Text, txtCountry.Text, txtDesc.Text);
                        clearAll();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void clearAll()
        {
            txtDesc.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Focus();
            txtCountry.Clear();
            txtName.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
