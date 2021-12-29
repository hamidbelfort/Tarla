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
    public partial class frmAddBook : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int bookId;
        public static int buyerId;
        public static bool IsEdit;
        int balance;
        Util util = new Util();
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            try
            {
                bsBank.DataSource = db.FillBank();
                bsPayType.DataSource=db.FillPayType();
                bsBuyer.DataSource = db.FillBuyer();
                if (IsEdit)
                {
                    bsBook.DataSource = db.FillBookById(bookId);
                    cmbBuyer.SelectedValue = buyerId;
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
                if (string.IsNullOrEmpty(cmbBuyer.Text))
                {
                    errorProvider1.SetError(cmbBuyer, "یک مشتری را انتخاب کنید");
                    cmbBuyer.Focus();
                }
                else if (string.IsNullOrEmpty(cmbBank.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbBank, "یک حساب بانکی را انتخاب کنید");
                    cmbBank.Focus();
                }
                else if (string.IsNullOrEmpty(cmbPayType.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbPayType, "نوع تراکنش را انتخاب کنید");
                    cmbPayType.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsBook.EndEdit();
                        db.UpdateBook(bookId, txtDate.Text, (int)cmbBuyer.SelectedValue, intAmount.Value, (int)cmbPayType.SelectedValue, (int)cmbBank.SelectedValue, txtDesc.Text);
                    }
                    else
                    {
                        db.InsertBook(txtDate.Text, (int)cmbBuyer.SelectedValue, intAmount.Value, (int)cmbPayType.SelectedValue, (int)cmbBank.SelectedValue, txtDesc.Text);
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
            lblCredit.Text = "0";
            lblDebt.Text = "0";
            cmbBuyer.Focus();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                balance = util.getBalance((int)cmbBuyer.SelectedValue);
                if (balance==0)
                {
                    lblCredit.Text = "0";
                    lblDebt.Text = "0";
                }
                else if(balance > 0)
                {
                    lblDebt.Text = balance.ToString("N0");
                    lblCredit.Text = "0";
                }
                else if(balance < 0)
                {
                    lblCredit.Text = Math.Abs(balance).ToString("N0");
                    lblDebt.Text = "0";
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
