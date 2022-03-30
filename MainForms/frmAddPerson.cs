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
    public partial class frmAddPerson : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int personType;
        public static int personId;
        public static bool IsEdit;
        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            performTransaction(personType);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    switch (personType)
                    {
                        case 1: //Reciever
                            groupPanel1.Text = "اطلاعات گیرنده بار";
                            Text= "ثبت مشخصات گیرنده بار";
                            break;
                        case 2://farmer
                            groupPanel1.Text = "اطلاعات کشاورز";
                            Text= "ثبت مشخصات کشاورز";
                            break;
                        case 3://clearance
                            groupPanel1.Text = "اطلاعات ترخیص کار";
                            Text = "ثبت مشخصات ترخیص کار";
                            break;
                    }
                    bsPerson.DataSource = db.FillPersonsById(personId);
                    cmbPersonType.SelectedIndex = personType - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void clearAll()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtDesc.Clear();
            txtOrigin.Clear();
            txtPhone.Text = string.Empty;
            cmbPersonType.Focus();
        }
        private void performTransaction(int target)
        {

            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام شخص الزامی است");
                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        bsPerson.EndEdit();
                        db.UpdatePerson(personId, personType, txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtOrigin.Text.Trim(), txtDesc.Text);
                    }
                    else
                    {
                        db.InsertPerson(personType, txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtOrigin.Text.Trim(), txtDesc.Text);
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

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                personType = cmbPersonType.SelectedIndex + 1;
            }
            catch
            {
                personType = 1;
            }
        }
        //**************************************************
        /*private void prepareForm(int target)
      {
          txtName.DataBindings.Clear();
          txtPhone.DataBindings.Clear();
          txtAddress.DataBindings.Clear();
          txtDesc.DataBindings.Clear();
          switch (target)
          {
              case 1: //receiver
                  txtName.DataBindings.Add(new Binding("Text", bsBuyer, "BuyerName"));
                  txtPhone.DataBindings.Add(new Binding("Text", bsBuyer, "Phone"));
                  txtAddress.DataBindings.Add(new Binding("Text", bsBuyer, "Address"));
                  txtDesc.DataBindings.Add(new Binding("Text", bsBuyer, "Description"));
                  break;
              case 2://farmer
                  txtName.DataBindings.Add(new Binding("Text", bsSeller, "SellerName"));
                  txtPhone.DataBindings.Add(new Binding("Text", bsSeller, "Phone"));
                  txtAddress.DataBindings.Add(new Binding("Text", bsSeller, "Address"));
                  txtDesc.DataBindings.Add(new Binding("Text", bsSeller, "Description"));
                  break;
              case 3://clearance
                  txtName.DataBindings.Add(new Binding("Text", bsReceiver, "ReceiverName"));
                  txtPhone.DataBindings.Add(new Binding("Text", bsReceiver, "Phone"));
                  txtAddress.DataBindings.Add(new Binding("Text", bsReceiver, "Address"));
                  txtDesc.DataBindings.Add(new Binding("Text", bsReceiver, "Description"));
                  break;
          }
      }*/
        /*switch (target)
                          {
                              case 1: //buyer
                                  bsBuyer.EndEdit();
                                  //db.UpdateBuyer(personId, txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                              case 2://seller
                                  bsSeller.EndEdit();
                                  //db.UpdateSeller(personId, txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                              case 3://receiver
                                  bsReceiver.EndEdit();
                                  //db.UpdateReceiver(personId, txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                          }
                          switch (target)
                          {
                              case 1: //buyer
                                  //db.InsertBuyer(txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                              case 2://seller
                                  //db.InsertSeller(txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                              case 3://receiver
                                  //db.InsertReceiver(txtName.Text.Trim(), txtPhone.Text, txtAddress.Text, txtDesc.Text);
                                  break;
                          }*/
    }
}
