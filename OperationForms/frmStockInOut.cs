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
namespace Tarla.OperationForms
{
    public partial class frmStockInOut : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        public static bool stockMode;
        int? sumStock = 0;
        public frmStockInOut()
        {
            InitializeComponent();
        }

        private void frmStockInOut_Load(object sender, EventArgs e)
        {
            loadAgain();
        }

        private void loadAgain()
        {
            try
            {
                gpMain.Text = stockMode ? "ورود به انبار" : "خروج از انبار";
                txtDesc.Text = string.Format("{0} {1}", stockMode ? "ورودی دستی به انبار " : "خروجی دستی از انبار ", "تاریخ : " + pd.getShortDate());
                bsDepot.DataSource = db.FillDepot();
                bsItem.DataSource = db.FillItems();
                txtDate.Text = pd.getShortDate();
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
                if (string.IsNullOrEmpty(txtDate.Text))
                {
                    errorProvider1.SetError(txtDate, "تاریخ الزامی است");
                    txtDate.Focus();
                }
                else if (string.IsNullOrEmpty(cmbItem.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbItem, "انتخاب کالا الزامی است");
                    cmbItem.Focus();
                }
                else if (string.IsNullOrEmpty(cmbDepot.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbDepot, "انتخاب انبار الزامی است");
                    cmbDepot.Focus();
                }
                else if (intQty.Value==0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(intQty, "تعداد کالا باید بیشتر از صفر باشد");
                    intQty.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (stockMode) //StockIn
                    {
                        db.InsertStock(txtDate.Text, 0, (int)cmbDepot.SelectedValue, (int)cmbItem.SelectedValue, intQty.Value, 0, txtDesc.Text);
                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        clearAll();
                    }
                    else //StockOut
                    {
                        
                        db.GetItemInStock((int)cmbDepot.SelectedValue, (int)cmbItem.SelectedValue, ref sumStock);
                        if (intQty.Value > sumStock)
                        {
                            MessageBoxFarsi.Show("مقدار درخواستی بیشتر از موجودی انبار است \n" + "موجودی : " + sumStock.ToString(), "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                            intQty.Focus();
                        }
                        else
                        {
                            db.InsertStock(txtDate.Text, 0, (int)cmbDepot.SelectedValue, (int)cmbItem.SelectedValue, 0, intQty.Value, txtDesc.Text);
                            MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                            clearAll();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void clearAll()
        {
            txtDate.Text = pd.getShortDate();
            txtDesc.Clear();
            cmbDepot.Text = string.Empty;
            cmbItem.Text = string.Empty;
            intQty.Value = 0;
            txtDate.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
