namespace BrewlyPOS.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnExcelSidebar = new System.Windows.Forms.Button();
            this.btnHistorySidebar = new System.Windows.Forms.Button();
            this.btnInventorySidebar = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mainInner = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnTabOrder = new System.Windows.Forms.Button();
            this.btnTabHistory = new System.Windows.Forms.Button();
            this.pnlTabLine = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.flpHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlCartItems = new System.Windows.Forms.Panel();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmptyCart = new System.Windows.Forms.Label();
            this.pnlOrderHeader = new System.Windows.Forms.Panel();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlOrderFooter = new System.Windows.Forms.Panel();
            this.pnlTotalBox = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rootTable.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mainInner.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlCartItems.SuspendLayout();
            this.pnlOrderHeader.SuspendLayout();
            this.pnlOrderFooter.SuspendLayout();
            this.pnlTotalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // rootTable
            // 
            this.rootTable.ColumnCount = 3;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.rootTable.Controls.Add(this.pnlSidebar, 0, 0);
            this.rootTable.Controls.Add(this.pnlMain, 1, 0);
            this.rootTable.Controls.Add(this.pnlOrder, 2, 0);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0, 0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 1;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Size = new System.Drawing.Size(1295, 671);
            this.rootTable.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.lblTableTitle);
            this.pnlSidebar.Controls.Add(this.txtTable);
            this.pnlSidebar.Controls.Add(this.lblMenuTitle);
            this.pnlSidebar.Controls.Add(this.btnExcelSidebar);
            this.pnlSidebar.Controls.Add(this.btnHistorySidebar);
            this.pnlSidebar.Controls.Add(this.btnInventorySidebar);
            this.pnlSidebar.Controls.Add(this.lblDateTime);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(20);
            this.pnlSidebar.Size = new System.Drawing.Size(204, 665);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(134, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "☕ BREWLY";
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblLogoSub.Location = new System.Drawing.Point(20, 50);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(71, 13);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "COFFEE POS";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblTableTitle.Location = new System.Drawing.Point(20, 80);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(51, 15);
            this.lblTableTitle.TabIndex = 2;
            this.lblTableTitle.Text = "TABLE #";
            // 
            // txtTable
            // 
            this.txtTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTable.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.txtTable.ForeColor = System.Drawing.Color.White;
            this.txtTable.Location = new System.Drawing.Point(20, 100);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(160, 50);
            this.txtTable.TabIndex = 3;
            this.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 180);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(42, 15);
            this.lblMenuTitle.TabIndex = 4;
            this.lblMenuTitle.Text = "MENU";
            // 
            // btnExcelSidebar
            // 
            this.btnExcelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelSidebar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnExcelSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelSidebar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnExcelSidebar.Location = new System.Drawing.Point(20, 200);
            this.btnExcelSidebar.Name = "btnExcelSidebar";
            this.btnExcelSidebar.Size = new System.Drawing.Size(160, 36);
            this.btnExcelSidebar.TabIndex = 5;
            this.btnExcelSidebar.Text = "📥  Download Records";
            this.btnExcelSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelSidebar.UseVisualStyleBackColor = false;
            this.btnExcelSidebar.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnHistorySidebar
            // 
            this.btnHistorySidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorySidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorySidebar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnHistorySidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorySidebar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistorySidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnHistorySidebar.Location = new System.Drawing.Point(20, 244);
            this.btnHistorySidebar.Name = "btnHistorySidebar";
            this.btnHistorySidebar.Size = new System.Drawing.Size(160, 36);
            this.btnHistorySidebar.TabIndex = 6;
            this.btnHistorySidebar.Text = "📋  Order History";
            this.btnHistorySidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorySidebar.UseVisualStyleBackColor = false;
            this.btnHistorySidebar.Click += new System.EventHandler(this.BtnHistorySidebar_Click);
            //
            // btnInventorySidebar
            //
            this.btnInventorySidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnInventorySidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventorySidebar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.btnInventorySidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventorySidebar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInventorySidebar.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.btnInventorySidebar.Location = new System.Drawing.Point(20, 288);
            this.btnInventorySidebar.Name = "btnInventorySidebar";
            this.btnInventorySidebar.Size = new System.Drawing.Size(160, 36);
            this.btnInventorySidebar.TabIndex = 8;
            this.btnInventorySidebar.Text = "📦  Inventory";
            this.btnInventorySidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventorySidebar.UseVisualStyleBackColor = false;
            this.btnInventorySidebar.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblDateTime.Location = new System.Drawing.Point(10, 1125);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(165, 40);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMain.Controls.Add(this.mainInner);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(213, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(709, 665);
            this.pnlMain.TabIndex = 1;
            // 
            // mainInner
            // 
            this.mainInner.ColumnCount = 1;
            this.mainInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 709F));
            this.mainInner.Controls.Add(this.pnlTabs, 0, 0);
            this.mainInner.Controls.Add(this.contentPanel, 0, 1);
            this.mainInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainInner.Location = new System.Drawing.Point(0, 0);
            this.mainInner.Name = "mainInner";
            this.mainInner.RowCount = 2;
            this.mainInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.mainInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainInner.Size = new System.Drawing.Size(709, 665);
            this.mainInner.TabIndex = 0;
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlTabs.Controls.Add(this.btnTabOrder);
            this.pnlTabs.Controls.Add(this.btnTabHistory);
            this.pnlTabs.Controls.Add(this.pnlTabLine);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(3, 3);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(703, 46);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnTabOrder
            // 
            this.btnTabOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnTabOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.btnTabOrder.FlatAppearance.BorderSize = 0;
            this.btnTabOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.btnTabOrder.Location = new System.Drawing.Point(0, 0);
            this.btnTabOrder.Name = "btnTabOrder";
            this.btnTabOrder.Size = new System.Drawing.Size(150, 49);
            this.btnTabOrder.TabIndex = 0;
            this.btnTabOrder.Text = "📋  NEW ORDER";
            this.btnTabOrder.UseVisualStyleBackColor = false;
            this.btnTabOrder.Click += new System.EventHandler(this.BtnTabOrder_Click);
            // 
            // btnTabHistory
            // 
            this.btnTabHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnTabHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabHistory.FlatAppearance.BorderSize = 0;
            this.btnTabHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnTabHistory.Location = new System.Drawing.Point(150, 0);
            this.btnTabHistory.Name = "btnTabHistory";
            this.btnTabHistory.Size = new System.Drawing.Size(140, 49);
            this.btnTabHistory.TabIndex = 1;
            this.btnTabHistory.Text = "🕐  HISTORY";
            this.btnTabHistory.UseVisualStyleBackColor = false;
            this.btnTabHistory.Click += new System.EventHandler(this.BtnTabHistory_Click);
            // 
            // pnlTabLine
            // 
            this.pnlTabLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.pnlTabLine.Location = new System.Drawing.Point(0, 49);
            this.pnlTabLine.Name = "pnlTabLine";
            this.pnlTabLine.Size = new System.Drawing.Size(150, 3);
            this.pnlTabLine.TabIndex = 2;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.pnlHistory);
            this.contentPanel.Controls.Add(this.flpProducts);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(3, 55);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(703, 607);
            this.contentPanel.TabIndex = 1;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlHistory.Controls.Add(this.flpHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(703, 607);
            this.pnlHistory.TabIndex = 0;
            this.pnlHistory.Visible = false;
            // 
            // flpHistory
            // 
            this.flpHistory.AutoScroll = true;
            this.flpHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.flpHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHistory.Location = new System.Drawing.Point(0, 0);
            this.flpHistory.Name = "flpHistory";
            this.flpHistory.Padding = new System.Windows.Forms.Padding(15);
            this.flpHistory.Size = new System.Drawing.Size(703, 607);
            this.flpHistory.TabIndex = 0;
            this.flpHistory.WrapContents = false;
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(0, 0);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.flpProducts.Size = new System.Drawing.Size(703, 607);
            this.flpProducts.TabIndex = 1;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlOrder.Controls.Add(this.pnlCartItems);
            this.pnlOrder.Controls.Add(this.pnlOrderHeader);
            this.pnlOrder.Controls.Add(this.pnlOrderFooter);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrder.Location = new System.Drawing.Point(928, 3);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(364, 665);
            this.pnlOrder.TabIndex = 2;
            // 
            // pnlCartItems
            // 
            this.pnlCartItems.AutoScroll = true;
            this.pnlCartItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlCartItems.Controls.Add(this.flpCart);
            this.pnlCartItems.Controls.Add(this.lblEmptyCart);
            this.pnlCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartItems.Location = new System.Drawing.Point(0, 60);
            this.pnlCartItems.Name = "pnlCartItems";
            this.pnlCartItems.Size = new System.Drawing.Size(364, 435);
            this.pnlCartItems.TabIndex = 0;
            // 
            // flpCart
            // 
            this.flpCart.AutoSize = true;
            this.flpCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.flpCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCart.Location = new System.Drawing.Point(0, 0);
            this.flpCart.Name = "flpCart";
            this.flpCart.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.flpCart.Size = new System.Drawing.Size(364, 10);
            this.flpCart.TabIndex = 0;
            this.flpCart.WrapContents = false;
            // 
            // lblEmptyCart
            // 
            this.lblEmptyCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptyCart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmptyCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblEmptyCart.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyCart.Name = "lblEmptyCart";
            this.lblEmptyCart.Size = new System.Drawing.Size(364, 435);
            this.lblEmptyCart.TabIndex = 1;
            this.lblEmptyCart.Text = "No items in order";
            this.lblEmptyCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrderHeader
            // 
            this.pnlOrderHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlOrderHeader.Controls.Add(this.lblOrderTitle);
            this.pnlOrderHeader.Controls.Add(this.btnClear);
            this.pnlOrderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderHeader.Name = "pnlOrderHeader";
            this.pnlOrderHeader.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnlOrderHeader.Size = new System.Drawing.Size(364, 60);
            this.pnlOrderHeader.TabIndex = 1;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.ForeColor = System.Drawing.Color.White;
            this.lblOrderTitle.Location = new System.Drawing.Point(15, 18);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(109, 25);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "📋  ORDER";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnClear.Location = new System.Drawing.Point(444, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // pnlOrderFooter
            // 
            this.pnlOrderFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlOrderFooter.Controls.Add(this.pnlTotalBox);
            this.pnlOrderFooter.Controls.Add(this.btnConfirm);
            this.pnlOrderFooter.Controls.Add(this.btnPrint);
            this.pnlOrderFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrderFooter.Location = new System.Drawing.Point(0, 495);
            this.pnlOrderFooter.Name = "pnlOrderFooter";
            this.pnlOrderFooter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlOrderFooter.Size = new System.Drawing.Size(364, 170);
            this.pnlOrderFooter.TabIndex = 2;
            // 
            // pnlTotalBox
            // 
            this.pnlTotalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlTotalBox.Controls.Add(this.lblTotalTitle);
            this.pnlTotalBox.Controls.Add(this.lblTotal);
            this.pnlTotalBox.Location = new System.Drawing.Point(15, 6);
            this.pnlTotalBox.Name = "pnlTotalBox";
            this.pnlTotalBox.Size = new System.Drawing.Size(335, 76);
            this.pnlTotalBox.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(15, 8);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(41, 15);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.lblTotal.Location = new System.Drawing.Point(12, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 47);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "₱0.00";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(15, 88);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(335, 44);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "CONFIRM ORDER";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnPrint.Location = new System.Drawing.Point(15, 138);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(335, 29);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "🖨️  PRINT RECEIPT (optional)";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1295, 671);
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brewly Coffee POS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rootTable.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.mainInner.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlCartItems.ResumeLayout(false);
            this.pnlCartItems.PerformLayout();
            this.pnlOrderHeader.ResumeLayout(false);
            this.pnlOrderHeader.PerformLayout();
            this.pnlOrderFooter.ResumeLayout(false);
            this.pnlTotalBox.ResumeLayout(false);
            this.pnlTotalBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        // ── Fields ─────────────────────────────────────────────────────────
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.TableLayoutPanel rootTable;
        // Sidebar
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnExcelSidebar;
        private System.Windows.Forms.Button btnHistorySidebar;
        private System.Windows.Forms.Button btnInventorySidebar;
        private System.Windows.Forms.Label lblDateTime;
        // Main
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnTabOrder;
        private System.Windows.Forms.Button btnTabHistory;
        private System.Windows.Forms.Panel pnlTabLine;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.FlowLayoutPanel flpHistory;
        // Order panel
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlOrderHeader;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlCartItems;
        private System.Windows.Forms.FlowLayoutPanel flpCart;
        private System.Windows.Forms.Label lblEmptyCart;
        private System.Windows.Forms.Panel pnlOrderFooter;
        private System.Windows.Forms.Panel pnlTotalBox;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TableLayoutPanel mainInner;
        private System.Windows.Forms.Panel contentPanel;
    }
}
