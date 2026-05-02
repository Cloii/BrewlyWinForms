namespace BrewlyPOS.Forms
{
    partial class InventoryForm
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
            // ── Declare all controls ──────────────────────────────────────
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.topBar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBranding = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlTabLine = new System.Windows.Forms.Panel();
            this.pnlBtnCell = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.pnlSepTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblPreviewHint = new System.Windows.Forms.Label();
            this.pnlSepBot = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();

            this.rootTable.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.topBar.SuspendLayout();
            this.pnlBranding.SuspendLayout();
            this.pnlBtnCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();

            // ══════════════════════════════════════════════════════════════
            // ROOT TABLE  — 2 columns: fluid left | 360px right panel
            // ══════════════════════════════════════════════════════════════
            this.rootTable.ColumnCount = 2;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.rootTable.Controls.Add(this.pnlLeft, 0, 0);
            this.rootTable.Controls.Add(this.pnlRight, 1, 0);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.RowCount = 1;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.rootTable.Margin = new System.Windows.Forms.Padding(0);

            // ══════════════════════════════════════════════════════════════
            // LEFT PANEL
            // ══════════════════════════════════════════════════════════════
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlLeft.Controls.Add(this.dgv);
            this.pnlLeft.Controls.Add(this.topBar);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20, 0, 12, 12);

            // ── TOP BAR: 2-cell TableLayoutPanel (logo left | button right) ──
            this.topBar.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.topBar.ColumnCount = 2;
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.topBar.Controls.Add(this.pnlBranding, 0, 0);
            this.topBar.Controls.Add(this.pnlBtnCell, 1, 0);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Height = 104;
            this.topBar.RowCount = 1;
            this.topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBar.Margin = new System.Windows.Forms.Padding(0);

            // ── Branding cell (logo + subtitle + page title + tab line) ──
            this.pnlBranding.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlBranding.Controls.Add(this.lblLogo);
            this.pnlBranding.Controls.Add(this.lblLogoSub);
            this.pnlBranding.Controls.Add(this.lblPageTitle);
            this.pnlBranding.Controls.Add(this.pnlTabLine);
            this.pnlBranding.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 12);
            this.lblLogo.Text = "☕ BREWLY";

            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblLogoSub.Location = new System.Drawing.Point(2, 40);
            this.lblLogoSub.Text = "COFFEE POS";

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(0, 60);
            this.lblPageTitle.Text = "📦  Inventory";

            // Orange underline — same as pnlTabLine in MainForm
            this.pnlTabLine.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.pnlTabLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pnlTabLine.Location = new System.Drawing.Point(0, 100);
            this.pnlTabLine.Size = new System.Drawing.Size(200, 3);

            // ── Button cell — ADD PRODUCT button centered vertically ──────
            this.pnlBtnCell.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlBtnCell.Controls.Add(this.btnAddNew);
            this.pnlBtnCell.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;   // centred in cell
            this.btnAddNew.Size = new System.Drawing.Size(140, 36);
            this.btnAddNew.Location = new System.Drawing.Point(7, 34);           // ~vertically centred in 104px bar
            this.btnAddNew.Text = "➕  ADD PRODUCT";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);

            // ══════════════════════════════════════════════════════════════
            // DATA GRID VIEW
            // ══════════════════════════════════════════════════════════════
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 44;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectionChanged += new System.EventHandler(this.Dgv_SelectionChanged);

            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            this.dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.dgv.EnableHeadersVisualStyles = false;

            this.dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);

            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.dgv.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            this.colId.HeaderText = "#ID";
            this.colId.Name = "colId";
            this.colId.FillWeight = 28F;
            this.colId.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

            this.colNum.HeaderText = "No.";
            this.colNum.Name = "colNum";
            this.colNum.FillWeight = 24F;
            this.colNum.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);

            this.colName.HeaderText = "PRODUCT NAME";
            this.colName.Name = "colName";
            this.colName.FillWeight = 120F;
            this.colName.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.colPrice.HeaderText = "PRICE";
            this.colPrice.Name = "colPrice";
            this.colPrice.FillWeight = 50F;
            this.colPrice.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.colPrice.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.colCategory.HeaderText = "CATEGORY";
            this.colCategory.Name = "colCategory";
            this.colCategory.FillWeight = 60F;
            this.colCategory.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);

            this.colImageUrl.HeaderText = "IMAGE URL";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.FillWeight = 120F;
            this.colImageUrl.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);

            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId, this.colNum, this.colName,
                this.colPrice, this.colCategory, this.colImageUrl
            });

            // ══════════════════════════════════════════════════════════════
            // RIGHT PANEL  (#0D0D0D — same as pnlOrder sidebar)
            // ══════════════════════════════════════════════════════════════
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            this.pnlRight.Controls.Add(this.pnlEdit);
            this.pnlRight.Controls.Add(this.lblHint);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblHint.Text = "← Select a row to edit\r\nor click  ➕ ADD PRODUCT";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ══════════════════════════════════════════════════════════════
            // EDIT PANEL
            // ══════════════════════════════════════════════════════════════
            this.pnlEdit.AutoScroll = true;
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Padding = new System.Windows.Forms.Padding(20, 20, 20, 16);
            this.pnlEdit.Visible = false;

            this.pnlEdit.Controls.Add(this.btnCancelEdit);
            this.pnlEdit.Controls.Add(this.btnDelete);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.pnlSepBot);
            this.pnlEdit.Controls.Add(this.lblPreviewHint);
            this.pnlEdit.Controls.Add(this.picPreview);
            this.pnlEdit.Controls.Add(this.btnPreview);
            this.pnlEdit.Controls.Add(this.txtImage);
            this.pnlEdit.Controls.Add(this.lblImage);
            this.pnlEdit.Controls.Add(this.txtCategory);
            this.pnlEdit.Controls.Add(this.lblCategory);
            this.pnlEdit.Controls.Add(this.txtPrice);
            this.pnlEdit.Controls.Add(this.lblPrice);
            this.pnlEdit.Controls.Add(this.txtName);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.pnlSepTop);
            this.pnlEdit.Controls.Add(this.lblEditTitle);

            int X = 20;
            int FW = 300;
            int Y = 20;

            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.lblEditTitle.Location = new System.Drawing.Point(X, Y);
            this.lblEditTitle.Text = "✏️  EDIT PRODUCT";
            Y += 34;

            this.pnlSepTop.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.pnlSepTop.Location = new System.Drawing.Point(X, Y);
            this.pnlSepTop.Size = new System.Drawing.Size(FW, 1);
            Y += 14;

            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblName.Location = new System.Drawing.Point(X, Y);
            this.lblName.Text = "PRODUCT NAME";
            Y += 18;

            this.txtName.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(X, Y);
            this.txtName.Size = new System.Drawing.Size(FW, 30);
            Y += 40;

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblPrice.Location = new System.Drawing.Point(X, Y);
            this.lblPrice.Text = "PRICE (₱)";
            Y += 18;

            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(X, Y);
            this.txtPrice.Size = new System.Drawing.Size(FW, 30);
            Y += 40;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblCategory.Location = new System.Drawing.Point(X, Y);
            this.lblCategory.Text = "CATEGORY";
            Y += 18;

            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(X, Y);
            this.txtCategory.Size = new System.Drawing.Size(FW, 30);
            Y += 40;

            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblImage.Location = new System.Drawing.Point(X, Y);
            this.lblImage.Text = "IMAGE URL";
            Y += 18;

            this.txtImage.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImage.ForeColor = System.Drawing.Color.White;
            this.txtImage.Location = new System.Drawing.Point(X, Y);
            this.txtImage.Size = new System.Drawing.Size(FW, 30);
            Y += 38;

            this.btnPreview.BackColor = System.Drawing.Color.Transparent;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.btnPreview.Location = new System.Drawing.Point(X, Y);
            this.btnPreview.Size = new System.Drawing.Size(FW, 30);
            this.btnPreview.Text = "🔍  PREVIEW IMAGE";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            Y += 38;

            this.picPreview.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picPreview.Location = new System.Drawing.Point(X, Y);
            this.picPreview.Size = new System.Drawing.Size(FW, 136);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Y += 144;

            this.lblPreviewHint.AutoSize = true;
            this.lblPreviewHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPreviewHint.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPreviewHint.Location = new System.Drawing.Point(X, Y);
            this.lblPreviewHint.Text = "Paste a direct image URL (Unsplash, etc.)";
            Y += 22;

            this.pnlSepBot.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.pnlSepBot.Location = new System.Drawing.Point(X, Y);
            this.pnlSepBot.Size = new System.Drawing.Size(FW, 1);
            Y += 14;

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(X, Y);
            this.btnSave.Size = new System.Drawing.Size(FW, 44);
            this.btnSave.Text = "💾  SAVE PRODUCT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            Y += 52;

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(200, 55, 55);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(X, Y);
            this.btnDelete.Size = new System.Drawing.Size(FW, 36);
            this.btnDelete.Text = "🗑️  DELETE PRODUCT";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            Y += 44;

            this.btnCancelEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.btnCancelEdit.Location = new System.Drawing.Point(X, Y);
            this.btnCancelEdit.Size = new System.Drawing.Size(FW, 30);
            this.btnCancelEdit.Text = "✕  CANCEL";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);

            // ══════════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brewly — Inventory Management";

            this.rootTable.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.pnlBranding.ResumeLayout(false);
            this.pnlBranding.PerformLayout();
            this.pnlBtnCell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        // ── Control fields ────────────────────────────────────────────────
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel topBar;
        private System.Windows.Forms.Panel pnlBranding;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTabLine;
        private System.Windows.Forms.Panel pnlBtnCell;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageUrl;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Panel pnlSepTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblPreviewHint;
        private System.Windows.Forms.Panel pnlSepBot;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}