namespace Tarla
{
    partial class frmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.prgSplash = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(0, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(499, 285);
            this.reflectionImage1.TabIndex = 0;
            // 
            // prgSplash
            // 
            // 
            // 
            // 
            this.prgSplash.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgSplash.Location = new System.Drawing.Point(0, 432);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(499, 30);
            this.prgSplash.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.prgSplash.TabIndex = 1;
            this.prgSplash.Text = "progressBarX1";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 462);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.reflectionImage1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSplash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ProgressBarX prgSplash;
        private System.Windows.Forms.Timer timer1;
    }
}