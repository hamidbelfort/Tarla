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
using Tarla.Classes;

namespace Tarla.MainForms
{
    public partial class frmAddFiscalYear : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int fiscalYearId = 0;
        public static bool autoExit;
        PersianDate pd = new PersianDate();
        public frmAddFiscalYear()
        {
            InitializeComponent();
        }

        private void frmAddFiscalYear_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsYear.DataSource = db.FillFiscalYearById(fiscalYearId);
                }
                else
                {
                    intYear.Value = int.Parse(pd.getYear());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (intYear.Value==0)
                {
                    errorProvider1.SetError(intYear, "سال مالی الزامی است");
                    intYear.Focus();
                }
                else
                {
                    if (IsEdit)
                    {
                        bsYear.EndEdit();
                        db.UpdateFiscalYear(fiscalYearId, intYear.Value);
                    }
                    else
                    {
                        bool? duplicate = false;
                        db.IsFiscalYearDuplicate(intYear.Value, ref duplicate);
                        if (duplicate==false)
                        {
                            db.InsertFiscalYear(intYear.Value);
                        }
                        else
                        {
                            errorProvider1.SetError(intYear, "سال مالی از قبل ایجاد شده است");
                            intYear.Focus();
                        }
                    }
                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    if (autoExit)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
