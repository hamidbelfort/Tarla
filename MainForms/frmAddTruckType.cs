﻿using System;
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
    public partial class frmAddTruckType : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static bool IsEdit;
        public static int truckTypeId = 0;
        public frmAddTruckType()
        {
            InitializeComponent();
        }

        private void frmAddTruckType_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsTruck.DataSource = db.FillTruckTypeById(truckTypeId);
                }
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
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "نام انبار الزامی است");
                    txtName.Focus();
                }
                else
                {
                    if (IsEdit)
                    {
                        bsTruck.EndEdit();
                        db.UpdateTruckType(truckTypeId, txtName.Text);
                    }
                    else
                    {
                        db.InsertDepot(txtName.Text);
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
