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

namespace Tarla.MiscForms
{
    public partial class frmLogs : DevComponents.DotNetBar.OfficeForm
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public static int userId;
        public static string fullname;
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Text = fullname + " نمایش ورود و خروج های";

                bsLogs.DataSource = db.FillLogs(userId);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLogs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLogs.Rows[e.RowIndex].Cells["clmRow"].Value = e.RowIndex + 1;
        }
    }
}
