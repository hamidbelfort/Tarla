namespace Tarla.MainForms
{
    partial class frmShowPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsSeller = new System.Windows.Forms.BindingSource(this.components);
            this.bsReceiver = new System.Windows.Forms.BindingSource(this.components);
            this.bsBuyer = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvSeller = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.sellerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReceiver = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.receiverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBuyer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buyerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radialMenu = new DevComponents.DotNetBar.RadialMenu();
            this.mnuRefresh = new DevComponents.DotNetBar.RadialMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyer)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // bsSeller
            // 
            //this.bsSeller.DataSource = typeof(Tarla.Seller);
            // 
            // bsReceiver
            // 
            //this.bsReceiver.DataSource = typeof(Tarla.Receiver);
            // 
            // bsBuyer
            // 
            //this.bsBuyer.DataSource = typeof(Tarla.Buyer);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnEdit);
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnDelete);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(7, 468);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(911, 40);
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
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.FocusCuesEnabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(812, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "  ویـرایـش";
            this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "  خـروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.FocusCuesEnabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(99, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "  حـذف";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.radialMenu);
            this.groupPanel1.Controls.Add(this.btnAdd);
            this.groupPanel1.Controls.Add(this.dgvSeller);
            this.groupPanel1.Controls.Add(this.dgvReceiver);
            this.groupPanel1.Controls.Add(this.dgvBuyer);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(7, 11);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(911, 451);
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
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(3, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "  جـدیـد";
            this.btnAdd.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSeller
            // 
            this.dgvSeller.AllowUserToAddRows = false;
            this.dgvSeller.AllowUserToDeleteRows = false;
            this.dgvSeller.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerIdDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvSeller.DataSource = this.bsSeller;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeller.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeller.EnableHeadersVisualStyles = false;
            this.dgvSeller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSeller.Location = new System.Drawing.Point(3, 36);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeller.Size = new System.Drawing.Size(899, 406);
            this.dgvSeller.TabIndex = 1;
            this.dgvSeller.Visible = false;
            // 
            // sellerIdDataGridViewTextBoxColumn
            // 
            this.sellerIdDataGridViewTextBoxColumn.DataPropertyName = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.HeaderText = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.Name = "sellerIdDataGridViewTextBoxColumn";
            this.sellerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "شماره تماس";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvReceiver
            // 
            this.dgvReceiver.AllowUserToAddRows = false;
            this.dgvReceiver.AllowUserToDeleteRows = false;
            this.dgvReceiver.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiverIdDataGridViewTextBoxColumn,
            this.receiverNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dgvReceiver.DataSource = this.bsReceiver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiver.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceiver.EnableHeadersVisualStyles = false;
            this.dgvReceiver.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReceiver.Location = new System.Drawing.Point(3, 36);
            this.dgvReceiver.Name = "dgvReceiver";
            this.dgvReceiver.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiver.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceiver.Size = new System.Drawing.Size(899, 406);
            this.dgvReceiver.TabIndex = 6;
            this.dgvReceiver.Visible = false;
            // 
            // receiverIdDataGridViewTextBoxColumn
            // 
            this.receiverIdDataGridViewTextBoxColumn.DataPropertyName = "ReceiverId";
            this.receiverIdDataGridViewTextBoxColumn.HeaderText = "ReceiverId";
            this.receiverIdDataGridViewTextBoxColumn.Name = "receiverIdDataGridViewTextBoxColumn";
            this.receiverIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // receiverNameDataGridViewTextBoxColumn
            // 
            this.receiverNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverName";
            this.receiverNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.receiverNameDataGridViewTextBoxColumn.Name = "receiverNameDataGridViewTextBoxColumn";
            this.receiverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiverNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "شماره تماس";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn1.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn1.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "توضیحات";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvBuyer
            // 
            this.dgvBuyer.AllowUserToAddRows = false;
            this.dgvBuyer.AllowUserToDeleteRows = false;
            this.dgvBuyer.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuyer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerIdDataGridViewTextBoxColumn,
            this.buyerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn2,
            this.addressDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2});
            this.dgvBuyer.DataSource = this.bsBuyer;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuyer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBuyer.EnableHeadersVisualStyles = false;
            this.dgvBuyer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvBuyer.Location = new System.Drawing.Point(3, 36);
            this.dgvBuyer.Name = "dgvBuyer";
            this.dgvBuyer.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuyer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBuyer.Size = new System.Drawing.Size(899, 406);
            this.dgvBuyer.TabIndex = 5;
            this.dgvBuyer.Visible = false;
            // 
            // buyerIdDataGridViewTextBoxColumn
            // 
            this.buyerIdDataGridViewTextBoxColumn.DataPropertyName = "BuyerId";
            this.buyerIdDataGridViewTextBoxColumn.HeaderText = "BuyerId";
            this.buyerIdDataGridViewTextBoxColumn.Name = "buyerIdDataGridViewTextBoxColumn";
            this.buyerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            this.buyerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyerNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // phoneDataGridViewTextBoxColumn2
            // 
            this.phoneDataGridViewTextBoxColumn2.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn2.HeaderText = "شماره تماس";
            this.phoneDataGridViewTextBoxColumn2.Name = "phoneDataGridViewTextBoxColumn2";
            this.phoneDataGridViewTextBoxColumn2.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn2.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn2
            // 
            this.addressDataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn2.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn2.Name = "addressDataGridViewTextBoxColumn2";
            this.addressDataGridViewTextBoxColumn2.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn2.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "توضیحات";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // radialMenu
            // 
            this.radialMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radialMenu.BackColor = System.Drawing.Color.Transparent;
            this.radialMenu.ForeColor = System.Drawing.Color.Black;
            this.radialMenu.Image = global::Tarla.Properties.Resources.buttonItem1_Image;
            this.radialMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnuRefresh});
            this.radialMenu.Location = new System.Drawing.Point(874, 3);
            this.radialMenu.Name = "radialMenu";
            this.radialMenu.Size = new System.Drawing.Size(28, 28);
            this.radialMenu.Symbol = "";
            this.radialMenu.SymbolSize = 13F;
            this.radialMenu.TabIndex = 2;
            this.radialMenu.Text = "radialMenu1";
            this.radialMenu.ItemClick += new System.EventHandler(this.radialMenu_ItemClick);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Symbol = "";
            this.mnuRefresh.Text = "تازه سازی";
            // 
            // frmShowPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(925, 518);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmShowPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyer)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsSeller;
        private System.Windows.Forms.BindingSource bsReceiver;
        private System.Windows.Forms.BindingSource bsBuyer;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.RadialMenu radialMenu;
        private DevComponents.DotNetBar.RadialMenuItem mnuRefresh;
    }
}