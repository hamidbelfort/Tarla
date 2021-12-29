namespace Tarla.OperationForms
{
    partial class frmShowFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowFactor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.gp1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdoBuyer = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbBuyer = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bsBuyer = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFactor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fReceiverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInvoiceView = new System.Windows.Forms.BindingSource(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.mskDate2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.mskDate1 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnNetSell = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoiceView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.gp1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(870, 532);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnNetSell);
            this.groupPanel2.Controls.Add(this.btnPrint);
            this.groupPanel2.Controls.Add(this.btnDelete);
            this.groupPanel2.Controls.Add(this.btnShow);
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 480);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(847, 40);
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
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.FocusCuesEnabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(652, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = " پیش نمایش";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.FocusCuesEnabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(99, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "  حـذف";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.FocusCuesEnabled = false;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(758, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnShow.Size = new System.Drawing.Size(80, 30);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = " جزئیات";
            this.btnShow.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
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
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "  خـروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // gp1
            // 
            this.gp1.BackColor = System.Drawing.Color.Transparent;
            this.gp1.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp1.Controls.Add(this.rdoBuyer);
            this.gp1.Controls.Add(this.rdoDate);
            this.gp1.Controls.Add(this.labelX3);
            this.gp1.Controls.Add(this.cmbBuyer);
            this.gp1.Controls.Add(this.dgvFactor);
            this.gp1.Controls.Add(this.labelX2);
            this.gp1.Controls.Add(this.labelX1);
            this.gp1.Controls.Add(this.mskDate2);
            this.gp1.Controls.Add(this.mskDate1);
            this.gp1.Controls.Add(this.btnAdd);
            this.gp1.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(847, 462);
            // 
            // 
            // 
            this.gp1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp1.Style.BackColorGradientAngle = 90;
            this.gp1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderBottomWidth = 1;
            this.gp1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderLeftWidth = 1;
            this.gp1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderRightWidth = 1;
            this.gp1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderTopWidth = 1;
            this.gp1.Style.CornerDiameter = 4;
            this.gp1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp1.TabIndex = 0;
            this.gp1.Text = "نمایش لیست فاکتور ها";
            // 
            // rdoBuyer
            // 
            this.rdoBuyer.AutoSize = true;
            this.rdoBuyer.Location = new System.Drawing.Point(820, 44);
            this.rdoBuyer.Name = "rdoBuyer";
            this.rdoBuyer.Size = new System.Drawing.Size(14, 13);
            this.rdoBuyer.TabIndex = 1;
            this.rdoBuyer.TabStop = true;
            this.rdoBuyer.UseVisualStyleBackColor = true;
            this.rdoBuyer.CheckedChanged += new System.EventHandler(this.rdoBuyer_CheckedChanged);
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(820, 15);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(14, 13);
            this.rdoDate.TabIndex = 0;
            this.rdoDate.TabStop = true;
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(712, 39);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "مشتری";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuyer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuyer.DataSource = this.bsBuyer;
            this.cmbBuyer.DisplayMember = "BuyerName";
            this.cmbBuyer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.ItemHeight = 17;
            this.cmbBuyer.Location = new System.Drawing.Point(454, 39);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(252, 23);
            this.cmbBuyer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbBuyer.TabIndex = 4;
            this.cmbBuyer.ValueMember = "BuyerId";
            this.cmbBuyer.SelectedIndexChanged += new System.EventHandler(this.cmbBuyer_SelectedIndexChanged);
            // 
            // bsBuyer
            // 
            this.bsBuyer.DataSource = typeof(Tarla.Buyer);
            // 
            // dgvFactor
            // 
            this.dgvFactor.AllowUserToAddRows = false;
            this.dgvFactor.AllowUserToDeleteRows = false;
            this.dgvFactor.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.buyerIdDataGridViewTextBoxColumn,
            this.buyerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.receiverNameDataGridViewTextBoxColumn,
            this.fReceiverNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.netSellDataGridViewTextBoxColumn});
            this.dgvFactor.DataSource = this.bsInvoiceView;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactor.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFactor.EnableHeadersVisualStyles = false;
            this.dgvFactor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFactor.Location = new System.Drawing.Point(5, 80);
            this.dgvFactor.Name = "dgvFactor";
            this.dgvFactor.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFactor.Size = new System.Drawing.Size(833, 352);
            this.dgvFactor.TabIndex = 6;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.buyerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "مشتری";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            this.buyerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "شماره تماس";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiverNameDataGridViewTextBoxColumn
            // 
            this.receiverNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverName";
            this.receiverNameDataGridViewTextBoxColumn.HeaderText = "گیرنده بندر";
            this.receiverNameDataGridViewTextBoxColumn.Name = "receiverNameDataGridViewTextBoxColumn";
            this.receiverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fReceiverNameDataGridViewTextBoxColumn
            // 
            this.fReceiverNameDataGridViewTextBoxColumn.DataPropertyName = "F_ReceiverName";
            this.fReceiverNameDataGridViewTextBoxColumn.HeaderText = "گیرنده دبی";
            this.fReceiverNameDataGridViewTextBoxColumn.Name = "fReceiverNameDataGridViewTextBoxColumn";
            this.fReceiverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.totalPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ کل";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netSellDataGridViewTextBoxColumn
            // 
            this.netSellDataGridViewTextBoxColumn.DataPropertyName = "NetSell";
            dataGridViewCellStyle8.Format = "N0";
            this.netSellDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.netSellDataGridViewTextBoxColumn.HeaderText = "صافی فروش";
            this.netSellDataGridViewTextBoxColumn.Name = "netSellDataGridViewTextBoxColumn";
            this.netSellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsInvoiceView
            // 
            this.bsInvoiceView.DataSource = typeof(Tarla.FactorView);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(421, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "تا  تاریخ";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(712, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "از  تاریخ";
            // 
            // mskDate2
            // 
            // 
            // 
            // 
            this.mskDate2.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDate2.ButtonClear.Visible = true;
            this.mskDate2.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDate2.FocusHighlightEnabled = true;
            this.mskDate2.Location = new System.Drawing.Point(224, 12);
            this.mskDate2.Mask = "####/##/##";
            this.mskDate2.Name = "mskDate2";
            this.mskDate2.Size = new System.Drawing.Size(191, 21);
            this.mskDate2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDate2.TabIndex = 3;
            this.mskDate2.Text = "";
            this.mskDate2.TextChanged += new System.EventHandler(this.mskDate2_TextChanged);
            // 
            // mskDate1
            // 
            // 
            // 
            // 
            this.mskDate1.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDate1.ButtonClear.Visible = true;
            this.mskDate1.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDate1.FocusHighlightEnabled = true;
            this.mskDate1.Location = new System.Drawing.Point(515, 12);
            this.mskDate1.Mask = "####/##/##";
            this.mskDate1.Name = "mskDate1";
            this.mskDate1.Size = new System.Drawing.Size(191, 21);
            this.mskDate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDate1.TabIndex = 2;
            this.mskDate1.Text = "";
            this.mskDate1.TextChanged += new System.EventHandler(this.mskDate1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "  جـدیـد";
            this.btnAdd.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnNetSell
            // 
            this.btnNetSell.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNetSell.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNetSell.FocusCuesEnabled = false;
            this.btnNetSell.Image = global::Tarla.Properties.Resources.dollar_folder_icon;
            this.btnNetSell.Location = new System.Drawing.Point(185, 2);
            this.btnNetSell.Name = "btnNetSell";
            this.btnNetSell.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnNetSell.Size = new System.Drawing.Size(133, 30);
            this.btnNetSell.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNetSell.TabIndex = 2;
            this.btnNetSell.Text = "  ثبت صافی فروش";
            this.btnNetSell.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnNetSell.Click += new System.EventHandler(this.btnNetSell_Click);
            // 
            // frmShowFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 532);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmShowFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowFactor";
            this.Load += new System.EventHandler(this.frmShowFactor_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoiceView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.GroupPanel gp1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDate2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDate1;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbBuyer;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoBuyer;
        private System.Windows.Forms.BindingSource bsBuyer;
        private System.Windows.Forms.BindingSource bsInvoiceView;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fReceiverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSellDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnNetSell;
    }
}