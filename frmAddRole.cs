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

namespace Tarla
{
    public partial class frmAddRole : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool ExitType = false;
        public static bool IsEdit = false;
        public static int RoleId = 0;
        public frmAddRole()
        {
            InitializeComponent();
        }

        private void frmAddRole_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsRoles.DataSource = db.FillRolesById(RoleId);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frmAddRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRoleName.Text))
                {
                    errorProvider1.SetError(txtRoleName, "نام نقش الزامی است");
                    txtRoleName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsRoles.EndEdit();
                        db.UpdateRole(RoleId,txtRoleName.Text.Trim(),chkSetting.Checked,chkUsers.Checked,chkBank.Checked,chkFactors.Checked);
                    }
                    else
                    {
                        db.InsertRole(txtRoleName.Text.Trim(), chkSetting.Checked, chkUsers.Checked, chkBank.Checked, chkFactors.Checked);
                        clearAll();
                        ExitType = false;
                    }
                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearAll()
        {
            txtRoleName.Clear();
            chkBank.Checked = false;
            chkFactors.Checked = false;
            chkSetting.Checked = false;
            chkUsers.Checked = false;
            txtRoleName.Focus();
        }
    }
}
