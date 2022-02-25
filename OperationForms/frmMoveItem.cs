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
    public partial class frmMoveItem : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        PersianDate pd = new PersianDate();
        int? sumStock;
        int sourceDepot, destDepot, itemId;
        public frmMoveItem()
        {
            InitializeComponent();
        }

        private void frmMoveItem_Load(object sender, EventArgs e)
        {
            loadAgain();
        }

        private void loadAgain()
        {
            try
            {
                txtDate.Text = pd.getShortDate();
                bsDepot.DataSource = db.FillDepot();
                bsItem.DataSource = db.FillItems();
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
                sourceDepot = (int)cmbDepot.SelectedValue;
                destDepot = (int)cmbDepot2.SelectedValue;
                itemId = (int)cmbItem.SelectedValue;
                if (sourceDepot==destDepot)
                {
                    errorProvider1.SetError(cmbDepot2, "انبار مقصد با انبار مبدا نمیتواند یکسان باشد");
                    cmbDepot2.Focus();
                }
                else
                {
                    if (intQty.Value==0)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(intQty, "تعداد کالا باید بیشتر از صفر باشد");
                        intQty.Focus();
                    }
                    else
                    {
                        sumStock = db.GetItemInStock(sourceDepot, itemId, ref sumStock);
                        if (intQty.Value > sumStock)
                        {
                            MessageBoxFarsi.Show("مقدار درخواستی بیشتر از موجودی انبار است \n" + "موجودی : " + sumStock.ToString(), "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                            intQty.Focus();
                        }
                        else
                        {
                            db.InsertStock(txtDate.Text, 0, sourceDepot, itemId, 0, intQty.Value, "جابجایی به " + cmbDepot2.Text);
                            db.InsertStock(txtDate.Text, 0, sourceDepot, itemId, intQty.Value, 0, "جابجایی از " + cmbDepot.Text);
                            MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        }
                    }
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
    }
}
