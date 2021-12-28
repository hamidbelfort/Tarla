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
    public partial class frmAddForeignReceiver : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public frmAddForeignReceiver()
        {
            InitializeComponent();
        }

        private void frmAddForeignReceiver_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
