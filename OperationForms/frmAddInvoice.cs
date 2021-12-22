using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarla.OperationForms
{
    public partial class frmAddInvoice : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        public frmAddInvoice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelX22_Click(object sender, EventArgs e)
        {

        }
    }
}
