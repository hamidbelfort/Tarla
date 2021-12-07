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
    public partial class frmShowGroups : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int groupId = 0;
        public frmShowGroups()
        {
            InitializeComponent();
        }

        private void frmShowGroups_Load(object sender, EventArgs e)
        {
            try
            {
                bsGroup.DataSource = db.FillGroups();
                if (dgvGroup.Rows.Count == 0)
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
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddGroup.IsEdit = false;

                new frmAddGroup().ShowDialog();

                loadAgain();
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
                frmAddGroup.IsEdit = true;

                frmAddGroup.groupId = (int)dgvGroup.CurrentRow.Cells[0].Value;

                new frmAddGroup().ShowDialog();

                db = new dcTarlaDataContext();
                loadAgain();
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
                    db.DeleteGroups((int)dgvGroup.CurrentRow.Cells[0].Value);
                    loadAgain();
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
        private void loadAgain()
        {
            try
            {
                bsGroup.DataSource = db.FillGroups();
                if (dgvGroup.Rows.Count == 0)
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
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }
    }
}
