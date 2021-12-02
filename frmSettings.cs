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
using Tarla.Classes;

namespace Tarla
{
    public partial class frmSettings : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();

        public static bool ExitType = false;
        float fontSize;
        string themeName;
        bool? ExistSetting = false;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTheme.DataSource = StyleTheme.getThemeList();
                db.ExistsSetting(ref ExistSetting);

                if (ExistSetting == true)
                {
                    bsSetting.DataSource = db.FillSetting();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
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
                if (string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    errorProvider1.SetError(txtCompanyName, "نام شرکت الزامی است");
                    txtCompanyName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (cmbFontSize.SelectedIndex>=0)
                    {
                        fontSize = (float)(cmbFontSize.SelectedValue);
                    }
                    else
                    {
                        fontSize = 10;
                    }
                    if (cmbTheme.SelectedIndex >= 0)
                    {
                        themeName = cmbTheme.SelectedValue.ToString(); ;
                    }
                    else
                    {
                        themeName = StyleTheme.styles.OfficeMobile2014.ToString();
                    }
                    if (ExistSetting == true)
                    {
                        bsSetting.EndEdit();
                        db.UpdateSetting(txtCompanyName.Text, txtFactorAddress.Text,txtFactorTel.Text, themeName, fontSize);
                    }
                    else
                    {
                        db.InsertSetting(txtCompanyName.Text, txtFactorAddress.Text, txtFactorTel.Text, themeName, fontSize);

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
    }
}
