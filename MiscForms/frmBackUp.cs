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
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Tarla.MiscForms
{
    public partial class frmBackUp : DevComponents.DotNetBar.OfficeForm
    {
        public frmBackUp()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void frmBackUp_Load(object sender, EventArgs e)
        {
            rdSimple.Checked = true;
            gpSimple.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rdSimple.Checked)
            {
                if (txtAddress1.Text==string.Empty)
                {
                    errorProvider1.SetError(txtAddress1, "مسیر ذخیره را مشخص کنید");
                    btnDialog.Focus();
                    
                }
                else
                {
                    errorProvider1.Clear();
                    
                    string connectionString = Tarla.Properties.Settings.Default.TarlaDBConnectionString;
                    string database = Tarla.Properties.Settings.Default.Database;
                    runSimpleBackUp(txtAddress1.Text, connectionString,database);
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
                    runAdvanceBackUp(txtAddress2.Text,txtServer.Text,txtDatabase.Text,txtUsername.Text,txtPassword.Text);
                }
            }
            else
            {
                MessageBoxFarsi.Show("یکی از گزینه های پشتیبان گیری را انتخاب کرده و مجددا تلاش کنید", "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button1);
                rdSimple.Focus();
            }
        }
        private void runAdvanceBackUp(string destination,string server,string database,string username,string password)
        {
            prg2.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(server,username,password));
                Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = database };
                dbbackup.Devices.AddDevice(destination, DeviceType.File);
                dbbackup.Initialize = true;
                dbbackup.PercentComplete += Dbbackup_PercentComplete;
                dbbackup.Complete += Dbbackup_Complete;
                dbbackup.SqlBackupAsync(dbserver);
                
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void Dbbackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error!=null)
            {
                lblStatus2.Invoke((MethodInvoker)delegate
                {
                    lblStatus2.Text = string.Format("پیغام : {0}", e.Error.Message);
                });
            }
        }

        private void Dbbackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prg2.Invoke((MethodInvoker)delegate 
            {
                prg2.Value = e.Percent;
                prg2.Text = $"{e.Percent}%";
                prg2.Update();
            });
        }

        private void runSimpleBackUp(string destination, string connectionString,string database)
        {
            prg1.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(connectionString));
                Backup dbbackup2 = new Backup() { Action = BackupActionType.Database, Database = database };
                dbbackup2.Devices.AddDevice(destination, DeviceType.File);
                dbbackup2.Initialize = true;
                dbbackup2.PercentComplete += Dbbackup2_PercentComplete;
                dbbackup2.Complete += Dbbackup2_Complete;
                dbbackup2.SqlBackupAsync(dbserver);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است \n" + ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void Dbbackup2_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus1.Invoke((MethodInvoker)delegate
                {
                    lblStatus1.Text = string.Format("پیغام : {0}", e.Error.Message);
                });
            }
        }

        private void Dbbackup2_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prg1.Invoke((MethodInvoker)delegate
            {
                prg1.Value = e.Percent;
                prg1.Text = $"{e.Percent}%";
                prg1.Update();
            });
            
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName!=string.Empty)
            {
                txtAddress1.Text = saveFileDialog1.FileName;
            }
        }

        private void btnDialog2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != string.Empty)
            {
                txtAddress2.Text = saveFileDialog1.FileName;
            }
        }
    }
}
