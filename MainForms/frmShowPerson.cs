using BehComponents;
using DevComponents.DotNetBar;
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
    public partial class frmShowPerson : DevComponents.DotNetBar.OfficeForm
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
                loadAgain();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
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
        private void loadAgain()
        {
            try
            {
                bsPerson.DataSource = db.FillPersons();
                if (dgvPerson.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddPerson.IsEdit = true;
                frmAddPerson.personType = (int)dgvPerson.CurrentRow.Cells[2].Value;
                frmAddPerson.personId = (int)dgvPerson.CurrentRow.Cells[1].Value;
                new frmAddPerson().ShowDialog();

                db = new dcTarlaDataContext();
                loadAgain();
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این مورد هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeletePerson((int)dgvPerson.CurrentRow.Cells[1].Value);
                    loadAgain();
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddPerson.IsEdit = false;
                frmAddPerson.personType = personType;
                new frmAddPerson().ShowDialog();
                loadAgain();
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

        private void radialMenu_ItemClick(object sender, EventArgs e)
        {
            RadialMenuItem item = sender as RadialMenuItem;
            if (item != null && !string.IsNullOrEmpty(item.Text))
            {
                switch (item.Name)
                {
                    case "mnuRefresh":
                        loadAgain();
                        break;
                }
            }
        }

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbPersonType.SelectedIndex)
                {
                    case 0:
                        bsPerson.DataSource = db.FillPersons();
                        break;
                    case 1:
                        loadByPersonType(1);
                        break;
                    case 2:
                        loadByPersonType(2);
                        break;
                    case 3:
                        loadByPersonType(3);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }
        private void loadByPersonType(int personType)
        {
            try
            {
                bsPerson.DataSource = db.FillPersonsByType(personType);
                if (dgvPerson.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void dgvPerson_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPerson.Rows[e.RowIndex].Cells["clmRow"].Value = e.RowIndex + 1;
        }
    }
}
