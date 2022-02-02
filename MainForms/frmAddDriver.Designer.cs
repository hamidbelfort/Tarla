namespace Tarla.MainForms
{
    partial class frmAddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDriver));
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPhone = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.bsDriver = new System.Windows.Forms.BindingSource(this.components);
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtLicenseId = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtLicensePlate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupPanel2.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 286);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(447, 40);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "  خـروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FocusCuesEnabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(361, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "   ثـبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupPanel1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtPhone);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtLicenseId);
            this.groupPanel1.Controls.Add(this.txtLicensePlate);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtName);
            this.groupPanel1.Controls.Add(this.txtAddress);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(447, 268);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "اطلاعات راننده";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhone.BackgroundStyle.Class = "TextBoxBorder";
            this.txtPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.ButtonClear.Visible = true;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Phone", true));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(126, 101);
            this.txtPhone.Mask = "00000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 22);
            this.txtPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "";
            // 
            // bsDriver
            // 
            this.bsDriver.DataSource = typeof(Tarla.Driver);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(322, 101);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 23);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "شماره تماس";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(322, 128);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(115, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "آدرس";
            // 
            // txtLicenseId
            // 
            this.txtLicenseId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicenseId.BackgroundStyle.Class = "TextBoxBorder";
            this.txtLicenseId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseId.ButtonClear.Visible = true;
            this.txtLicenseId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "LicenseId", true));
            this.txtLicenseId.ForeColor = System.Drawing.Color.Black;
            this.txtLicenseId.Location = new System.Drawing.Point(126, 45);
            this.txtLicenseId.Mask = "00000000000";
            this.txtLicenseId.Name = "txtLicenseId";
            this.txtLicenseId.Size = new System.Drawing.Size(190, 22);
            this.txtLicenseId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtLicenseId.TabIndex = 1;
            this.txtLicenseId.Text = "";
            // 
            // txtLicensePlate
            // 
            // 
            // 
            // 
            this.txtLicensePlate.Border.Class = "TextBoxBorder";
            this.txtLicensePlate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicensePlate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "LicensePlate", true));
            this.txtLicensePlate.DisabledBackColor = System.Drawing.Color.White;
            this.txtLicensePlate.Location = new System.Drawing.Point(30, 72);
            this.txtLicensePlate.MaxLength = 20;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.PreventEnterBeep = true;
            this.txtLicensePlate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLicensePlate.Size = new System.Drawing.Size(286, 23);
            this.txtLicensePlate.TabIndex = 2;
            this.txtLicensePlate.WatermarkText = "الزامی";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(322, 15);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(115, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "نام و نام خانوادگی";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(322, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(115, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "شماره گواهینامه";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "DriverName", true));
            this.txtName.DisabledBackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(30, 16);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(286, 23);
            this.txtName.TabIndex = 0;
            this.txtName.WatermarkText = "الزامی";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Address", true));
            this.txtAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(30, 129);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(286, 105);
            this.txtAddress.TabIndex = 4;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(322, 71);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(115, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "شماره پلاک کامیون";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddDriver
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(470, 332);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddDriver";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت مشخصات راننده";
            this.Load += new System.EventHandler(this.frmAddDriver_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSave;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtLicenseId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLicensePlate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtPhone;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsDriver;
    }
}