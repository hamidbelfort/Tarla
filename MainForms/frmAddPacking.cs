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
    public partial class frmAddPacking : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int packingId = 0;
        public frmAddPacking()
        {
            InitializeComponent();
        }

        private void frmAddPacking_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsPacking.DataSource = db.FillPackingById(packingId);
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
                    errorProvider1.SetError(txtName, "نام بسته بندی الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsPacking.EndEdit();
                        db.UpdatePacking(packingId, txtName.Text.Trim());
                    }
                    else
                    {
                        db.InsertPacking(txtName.Text.Trim());
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
            txtName.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
