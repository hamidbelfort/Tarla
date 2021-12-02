using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarla
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgSplash.Value += 20;
            if (prgSplash.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
