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
    public partial class frmShowPerson : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int personType;
        public frmShowPerson()
        {
            InitializeComponent();
        }

        private void frmShowPerson_Load(object sender, EventArgs e)
        {
            try
            {
                switch (personType)
                {
                    case 1: //buyer
                        groupPanel1.Text = "نمایش لیست مشتریان";
                        bsBuyer.DataSource = db.FillBuyer();
                        dgvBuyer.Visible = true;
                        checkData(dgvBuyer);
                        break;
                    case 2://seller
                        groupPanel1.Text = "نمایش لیست فروشندگان محصول";
                        bsSeller.DataSource = db.FillSeller();
                        dgvSeller.Visible = true;
                        checkData(dgvSeller);
                        break;
                    case 3://receiver
                        groupPanel1.Text = "نمایش لیست تحویل گیرنده ها";
                        bsReceiver.DataSource = db.FillReceiver();
                        dgvReceiver.Visible = true;
                        checkData(dgvReceiver);
                        break;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void checkData(DevComponents.DotNetBar.Controls.DataGridViewX dgvTarget)
        {
            if (dgvTarget.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                
            }
            else
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                dgvTarget.Columns[0].Visible = false;
            }
        }
        private void loadAgain(int bsTarget)
        {
            try
            {
                switch (bsTarget)
                {
                    case 1://buyer
                        
                        bsBuyer.DataSource = db.FillBuyer();
                        checkData(dgvBuyer);
                        break;
                    case 2://seller
                        bsSeller.DataSource = db.FillSeller();
                        checkData(dgvSeller);
                        break;
                    case 3://receiver
                        bsReceiver.DataSource = db.FillReceiver();
                        checkData(dgvReceiver);
                        break;
                }
                
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddPerson.IsEdit = false;
                frmAddPerson.personType = personType;
                new frmAddPerson().ShowDialog();
                loadAgain(personType);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddPerson.IsEdit = true;
                switch (personType)
                {
                    case 1://buyer
                        frmAddPerson.personType = 1;
                        frmAddPerson.personId = (int)dgvBuyer.CurrentRow.Cells[0].Value;
                        break;
                    case 2://seller
                        frmAddPerson.personType = 2;
                        frmAddPerson.personId = (int)dgvSeller.CurrentRow.Cells[0].Value;
                        break;
                    case 3://receiver
                        frmAddPerson.personType = 3;
                        frmAddPerson.personId = (int)dgvReceiver.CurrentRow.Cells[0].Value;
                        break;
                }
                new frmAddPerson().ShowDialog();

                db = new dcTarlaDataContext();
                loadAgain(personType);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    switch (personType)
                    {
                        case 1://buyer
                            db.DeleteBuyer((int)dgvBuyer.CurrentRow.Cells[0].Value);
                            break;
                        case 2://seller
                            db.DeleteSeller((int)dgvSeller.CurrentRow.Cells[0].Value);
                            break;
                        case 3://receiver
                            db.DeleteReceiver((int)dgvReceiver.CurrentRow.Cells[0].Value);
                            break;
                    }
                    loadAgain(personType);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
