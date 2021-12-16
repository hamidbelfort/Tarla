namespace Tarla
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnItem = new DevComponents.DotNetBar.ButtonItem();
            this.btnCompany = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuyers = new DevComponents.DotNetBar.ButtonItem();
            this.btnSellers = new DevComponents.DotNetBar.ButtonItem();
            this.btnReceivers = new DevComponents.DotNetBar.ButtonItem();
            this.btnCategory = new DevComponents.DotNetBar.ButtonItem();
            this.btnProduct = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuy = new DevComponents.DotNetBar.ButtonItem();
            this.btnSell = new DevComponents.DotNetBar.ButtonItem();
            this.btnItemGroup = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2,
            this.ribbonTabItem3,
            this.ribbonTabItem4});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(799, 187);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar6);
            this.ribbonPanel2.Controls.Add(this.ribbonBar5);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(799, 184);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.DragDropSupport = true;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBuy});
            this.ribbonBar6.Location = new System.Drawing.Point(86, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(78, 181);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 1;
            this.ribbonBar6.Text = "خرید کالا";
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.DragDropSupport = true;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSell});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(83, 181);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 0;
            this.ribbonBar5.Text = "حواله فروش";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar4);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(799, 128);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItem,
            this.btnItemGroup});
            this.ribbonBar4.Location = new System.Drawing.Point(463, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(152, 125);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 3;
            this.ribbonBar4.Text = "کالا";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCompany});
            this.ribbonBar3.Location = new System.Drawing.Point(381, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(82, 125);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "شرکت";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBuyers,
            this.btnSellers,
            this.btnReceivers});
            this.ribbonBar2.Location = new System.Drawing.Point(158, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(223, 125);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "اشخاص";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCategory,
            this.btnProduct});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(155, 125);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "محصولات";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(799, 184);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(799, 184);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "تعاریف اولیه";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "عملیات";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "گزارش";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "تنظیمات";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(171, 310);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(396, 40);
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
            this.groupPanel2.TabIndex = 10;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(453, 406);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(243, 23);
            this.textBoxX1.TabIndex = 11;
            this.textBoxX1.WatermarkText = "الزامی";
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
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FocusCuesEnabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(310, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "   ثـبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Tarla.Properties.Resources.Exit_icon;
            this.buttonX2.Location = new System.Drawing.Point(259, 271);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.buttonX2.Size = new System.Drawing.Size(87, 33);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 6;
            this.buttonX2.Text = "   خروج";
            this.buttonX2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Tarla.Properties.Resources.Actions_edit_redo_icon;
            this.buttonX1.Location = new System.Drawing.Point(362, 271);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.buttonX1.Size = new System.Drawing.Size(87, 33);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "   ورود   ";
            this.buttonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnItem
            // 
            this.btnItem.Image = global::Tarla.Properties.Resources.product_icon;
            this.btnItem.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnItem.Name = "btnItem";
            this.btnItem.SubItemsExpandWidth = 14;
            this.btnItem.Text = "ثبت کالا";
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.SubItemsExpandWidth = 14;
            this.btnCompany.Tooltip = "مشتریان";
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnBuyers
            // 
            this.btnBuyers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBuyers.Image = global::Tarla.Properties.Resources.Groups_Meeting_Light_icon;
            this.btnBuyers.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnBuyers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuyers.Name = "btnBuyers";
            this.btnBuyers.SubItemsExpandWidth = 14;
            this.btnBuyers.Text = "مشتریان";
            this.btnBuyers.Tooltip = "مشتریان";
            this.btnBuyers.Click += new System.EventHandler(this.btnBuyers_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSellers.Image = global::Tarla.Properties.Resources.seller;
            this.btnSellers.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnSellers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.SubItemsExpandWidth = 14;
            this.btnSellers.Text = "فروشنده محصول";
            this.btnSellers.Tooltip = "فروشنده محصول";
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnReceivers
            // 
            this.btnReceivers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReceivers.Image = global::Tarla.Properties.Resources.receiver;
            this.btnReceivers.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnReceivers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReceivers.Name = "btnReceivers";
            this.btnReceivers.SubItemsExpandWidth = 14;
            this.btnReceivers.Text = "گیرنده بار";
            this.btnReceivers.Tooltip = "گیرنده بار";
            this.btnReceivers.Click += new System.EventHandler(this.btnReceivers_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnCategory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCategory.Stretch = true;
            this.btnCategory.SubItemsExpandWidth = 14;
            this.btnCategory.Text = "دسته بندی";
            this.btnCategory.Tooltip = "دسته بندی";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnProduct.Image = global::Tarla.Properties.Resources.product;
            this.btnProduct.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnProduct.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Stretch = true;
            this.btnProduct.SubItemsExpandWidth = 14;
            this.btnProduct.Text = "محصول";
            this.btnProduct.Tooltip = "محصول";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Image = global::Tarla.Properties.Resources.buyitem;
            this.btnBuy.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Stretch = true;
            this.btnBuy.SubItemsExpandWidth = 14;
            this.btnBuy.Tooltip = "خرید کالا";
            // 
            // btnSell
            // 
            this.btnSell.Image = global::Tarla.Properties.Resources.shopping_bag_icon;
            this.btnSell.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnSell.Name = "btnSell";
            this.btnSell.SubItemsExpandWidth = 14;
            // 
            // btnItemGroup
            // 
            this.btnItemGroup.Image = global::Tarla.Properties.Resources.productGroup2;
            this.btnItemGroup.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btnItemGroup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnItemGroup.Name = "btnItemGroup";
            this.btnItemGroup.SubItemsExpandWidth = 14;
            this.btnItemGroup.Text = "گروه کالا";
            this.btnItemGroup.Click += new System.EventHandler(this.btnItemGroup_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 565);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار باربری تارلا";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnProduct;
        private DevComponents.DotNetBar.ButtonItem btnCategory;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnBuyers;
        private DevComponents.DotNetBar.ButtonItem btnSellers;
        private DevComponents.DotNetBar.ButtonItem btnReceivers;
        private DevComponents.DotNetBar.ButtonItem btnCompany;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnBuy;
        private DevComponents.DotNetBar.ButtonItem btnItem;
        private DevComponents.DotNetBar.ButtonItem btnSell;
        private DevComponents.DotNetBar.ButtonItem btnItemGroup;
    }
}