using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
namespace Tarla.MiscForms
{
    public partial class frmRestore : DevComponents.DotNetBar.OfficeForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void rdSimple_CheckedChanged(object sender, EventArgs e)
        {
            gpAdvance.Enabled = false;
            gpSimple.Enabled = true;
        }

        private void rdAdvance_CheckedChanged(object sender, EventArgs e)
        {
            gpAdvance.Enabled = true;
            gpSimple.Enabled = false;
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            rdSimple.Checked = true;
            gpSimple.Enabled = true;
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != string.Empty)
            {
                txtAddress1.Text = openFileDialog1.FileName;
            }
        }

        private void btnDialog2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != string.Empty)
            {
                txtAddress2.Text = openFileDialog1.FileName;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rdSimple.Checked)
            {
                if (txtAddress1.Text == string.Empty)
                {
                    errorProvider1.SetError(txtAddress1, "مسیر ذخیره را مشخص کنید");
                    btnDialog.Focus();

                }
                else
                {
                    errorProvider1.Clear();

                    string connectionString = Tarla.Properties.Settings.Default.TarlaDBConnectionString;
                    string database = Tarla.Properties.Settings.Default.Database;
                    if (MessageBoxFarsi.Show("آیا از بازگردانی پشتیبان اطمینان دارید؟ \n"+ "این عملیات غیرقابل بازگشت خواهد بود", "تأیید بازگردانی", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                    {
                        runSimpleRestore(txtAddress1.Text, connectionString, database);
                    }
                    
                }
            }
            else if (rdAdvance.Checked)
            {
                if (txtAddress2.Text == string.Empty)
                {
                    errorProvider1.SetError(txtAddress2, "مسیر ذخیره را مشخص کنید");
                    btnDialog.Focus();
                }
                else if (string.IsNullOrEmpty(txtServer.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtServer, "نام سرور را وارد کنید");
                    txtServer.Focus();
                }
                else if (string.IsNullOrEmpty(txtDatabase.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtDatabase, "نام بانک اطلاعاتی را وارد کنید");
                    txtDatabase.Focus();
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUsername, "نام کاربری را وارد کنید");
                    txtUsername.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtPassword, "رمز عبور را وارد کنید");
                    txtPassword.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    if (MessageBoxFarsi.Show("آیا از بازگردانی پشتیبان اطمینان دارید؟ \n" + "این عملیات غیرقابل بازگشت خواهد بود", "تأیید بازگردانی", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                    {
                        runAdvanceRestore(txtAddress2.Text, txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
                    }
                }
            }
            else
            {
                MessageBoxFarsi.Show("یکی از گزینه های پشتیبان گیری را انتخاب کرده و مجددا تلاش کنید", "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button1);
                rdSimple.Focus();
            }
        }
        private void runAdvanceRestore(string source, string server, string database, string username, string password)
        {
            prg2.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(server, username, password));
                Restore dbRestore = new Restore() { Database = database, Action = RestoreActionType.Database, NoRecovery = false, ReplaceDatabase = true };
                dbRestore.Devices.AddDevice(source, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete; ;
                dbRestore.Complete += DbRestore_Complete; ;
                dbRestore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus2.Invoke((MethodInvoker)delegate
                {
                    lblStatus2.Text = string.Format("پیغام : {0}", e.Error.Message);
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prg2.Invoke((MethodInvoker)delegate
            {
                prg2.Value = e.Percent;
                prg2.Text = $"{e.Percent}%";
                prg2.Update();
            });
        }
        private void runSimpleRestore(string source, string connectionString, string database)
        {
            prg1.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(connectionString));
                Restore dbRestore2 = new Restore() { Database = database, Action = RestoreActionType.Database, NoRecovery = false, ReplaceDatabase = true };
                dbRestore2.Devices.AddDevice(source, DeviceType.File);
                dbRestore2.PercentComplete += DbRestore2_PercentComplete; ;
                dbRestore2.Complete += DbRestore2_Complete; ;
                dbRestore2.SqlRestoreAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void DbRestore2_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus1.Invoke((MethodInvoker)delegate
                {
                    lblStatus1.Text = string.Format("پیغام : {0}", e.Error.Message);
                });
            }
        }

        private void DbRestore2_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prg1.Invoke((MethodInvoker)delegate
            {
                prg1.Value = e.Percent;
                prg1.Text = $"{e.Percent}%";
                prg1.Update();
            });
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
