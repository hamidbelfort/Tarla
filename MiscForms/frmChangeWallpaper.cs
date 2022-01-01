using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BehComponents;

namespace Tarla.MiscForms
{
    public partial class frmChangeWallpaper : Form
    {
        dcTarlaDataContext db = new dcTarlaDataContext();
        string filename;
        FileInfo temp;
        ToolTip tip = new ToolTip();
        public frmChangeWallpaper()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                filename = openFileDialog1.FileName;
                temp = new FileInfo(filename);
                pictureBox1.ImageLocation = filename;
                tip.SetToolTip(pictureBox1, "پیش نمایش تصویر");
                btnApply.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp.Exists)
                {
                    if (MessageBoxFarsi.Show("آیا از تغییر تصویر پس زمینه اطمینان دارید؟", "تغییر پس زمینه", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question) == DialogResult.Yes)
                    {
                        db.SaveWallpaper(filename);
                        btnApply.Enabled = false;
                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);

                    }
                }
                else
                {
                    MessageBoxFarsi.Show("تصویر مورد نظر وجود ندارد", "", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                    btnApply.Enabled = false;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("با این کار تصویر پس زمینه تصویر اولیه میشود.آیا ادامه میدهید؟", "تایید بازگشت به تنظیم اولیه", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question) == DialogResult.Yes)
                {
                    db.ClearWallpaper();
                    MessageBoxFarsi.Show("تنظیمات پس زمینه به تنظیم اولیه تغییر یافت", "", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }

        private void frmChangeWallpaper_Load(object sender, EventArgs e)
        {
            tip.ToolTipIcon = ToolTipIcon.Info;
            tip.UseAnimation = true;
            tip.UseFading = true;
            btnApply.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
