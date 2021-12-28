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
    public partial class frmShowFactor : Form
    {
        public frmShowFactor()
        {
            InitializeComponent();
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = true;
            mskDate2.Enabled = true;
            cmbBuyer.Enabled = false;
        }

        private void rdoBuyer_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = false;
            mskDate2.Enabled = false;
            cmbBuyer.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
