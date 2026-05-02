namespace BrewlyPOS.Forms
{
    partial class PaymentForm
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
            this.pnlRoot         = new System.Windows.Forms.Panel();
            this.lblTitle        = new System.Windows.Forms.Label();
            // Total
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal        = new System.Windows.Forms.Label();
            // Customer
            this.lblCustomerCap  = new System.Windows.Forms.Label();
            this.txtCustomer     = new System.Windows.Forms.TextBox();
            // Table
            this.lblTableCap     = new System.Windows.Forms.Label();
            this.txtTable        = new System.Windows.Forms.TextBox();
            // Payment method
            this.lblMethodCap    = new System.Windows.Forms.Label();
            this.pnlMethods      = new System.Windows.Forms.Panel();
            this.btnCash         = new System.Windows.Forms.Button();
            this.btnGCash        = new System.Windows.Forms.Button();
            this.btnCard         = new System.Windows.Forms.Button();
            this.btnPayMaya      = new System.Windows.Forms.Button();
            // Payment amount
            this.lblAmountCap    = new System.Windows.Forms.Label();
            this.txtAmount       = new System.Windows.Forms.TextBox();
            // Change
            this.pnlChange       = new System.Windows.Forms.Panel();
            this.lblChangeCap    = new System.Windows.Forms.Label();
            this.lblChange       = new System.Windows.Forms.Label();
            // Actions
            this.btnCancel       = new System.Windows.Forms.Button();
            this.btnComplete     = new System.Windows.Forms.Button();

            int W = 440;

            // Root
            this.pnlRoot.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            this.pnlRoot.Padding   = new System.Windows.Forms.Padding(30);

            // Title
            this.lblTitle.Text      = "💳  Payment";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(30, 25);
            this.lblTitle.AutoSize  = true;

            // Total caption
            this.lblTotalCaption.Text      = "Total Amount";
            this.lblTotalCaption.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblTotalCaption.Location  = new System.Drawing.Point(30, 72);
            this.lblTotalCaption.AutoSize  = true;

            this.lblTotal.Text      = "₱0.00";
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.lblTotal.Location  = new System.Drawing.Point(28, 90);
            this.lblTotal.AutoSize  = true;

            // Customer
            this.lblCustomerCap.Text      = "Customer Name (Optional)";
            this.lblCustomerCap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerCap.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblCustomerCap.Location  = new System.Drawing.Point(30, 140);
            this.lblCustomerCap.AutoSize  = true;

            this.txtCustomer.Location        = new System.Drawing.Point(30, 158);
            this.txtCustomer.Size            = new System.Drawing.Size(W, 36);
            this.txtCustomer.Font            = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCustomer.BackColor       = System.Drawing.Color.FromArgb(13, 13, 13);
            this.txtCustomer.ForeColor       = System.Drawing.Color.White;
            this.txtCustomer.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;

            // Table
            this.lblTableCap.Text      = "Table Number";
            this.lblTableCap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTableCap.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblTableCap.Location  = new System.Drawing.Point(30, 206);
            this.lblTableCap.AutoSize  = true;

            this.txtTable.Location        = new System.Drawing.Point(30, 224);
            this.txtTable.Size            = new System.Drawing.Size(W, 36);
            this.txtTable.Font            = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTable.BackColor       = System.Drawing.Color.FromArgb(13, 13, 13);
            this.txtTable.ForeColor       = System.Drawing.Color.White;
            this.txtTable.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;

            // Method
            this.lblMethodCap.Text      = "Payment Method";
            this.lblMethodCap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMethodCap.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblMethodCap.Location  = new System.Drawing.Point(30, 272);
            this.lblMethodCap.AutoSize  = true;

            this.pnlMethods.Location  = new System.Drawing.Point(30, 290);
            this.pnlMethods.Size      = new System.Drawing.Size(W, 70);
            this.pnlMethods.BackColor = System.Drawing.Color.Transparent;

            int bw = 102;
            SetupMethodButton(this.btnCash,    "💵\nCash",    0,        "Cash");
            SetupMethodButton(this.btnGCash,   "📱\nGCash",  bw + 4,   "GCash");
            SetupMethodButton(this.btnCard,    "💳\nCard",   (bw+4)*2, "Card");
            SetupMethodButton(this.btnPayMaya, "🏦\nPayMaya",(bw+4)*3, "PayMaya");
            this.btnCash.Width = bw; this.btnGCash.Width = bw;
            this.btnCard.Width = bw; this.btnPayMaya.Width = W - (bw+4)*3;

            this.pnlMethods.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnCash, this.btnGCash, this.btnCard, this.btnPayMaya
            });

            // Amount
            this.lblAmountCap.Text      = "Payment Amount";
            this.lblAmountCap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmountCap.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblAmountCap.Location  = new System.Drawing.Point(30, 372);
            this.lblAmountCap.AutoSize  = true;

            this.txtAmount.Location        = new System.Drawing.Point(30, 390);
            this.txtAmount.Size            = new System.Drawing.Size(W, 36);
            this.txtAmount.Font            = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.BackColor       = System.Drawing.Color.FromArgb(13, 13, 13);
            this.txtAmount.ForeColor       = System.Drawing.Color.White;
            this.txtAmount.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.TextChanged    += new System.EventHandler(this.TxtAmount_TextChanged);

            // Change
            this.pnlChange.Location  = new System.Drawing.Point(30, 438);
            this.pnlChange.Size      = new System.Drawing.Size(W, 54);
            this.pnlChange.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);

            this.lblChangeCap.Text      = "Change";
            this.lblChangeCap.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChangeCap.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.lblChangeCap.Location  = new System.Drawing.Point(15, 14);
            this.lblChangeCap.AutoSize  = true;

            this.lblChange.Text      = "₱0.00";
            this.lblChange.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblChange.Anchor    = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.lblChange.AutoSize  = true;
            this.lblChange.Location  = new System.Drawing.Point(W - 130, 12);

            this.pnlChange.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblChangeCap, this.lblChange
            });

            // Buttons
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.Location  = new System.Drawing.Point(30, 508);
            this.btnCancel.Size      = new System.Drawing.Size(210, 44);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 58, 58);
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click    += new System.EventHandler(this.BtnCancel_Click);

            this.btnComplete.Text      = "Complete Sale";
            this.btnComplete.Location  = new System.Drawing.Point(248, 508);
            this.btnComplete.Size      = new System.Drawing.Size(222, 44);
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnComplete.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.Enabled   = false;
            this.btnComplete.Click    += new System.EventHandler(this.BtnComplete_Click);

            // Add all to root
            this.pnlRoot.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle,
                this.lblTotalCaption, this.lblTotal,
                this.lblCustomerCap, this.txtCustomer,
                this.lblTableCap, this.txtTable,
                this.lblMethodCap, this.pnlMethods,
                this.lblAmountCap, this.txtAmount,
                this.pnlChange,
                this.btnCancel, this.btnComplete
            });

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(500, 576);
            this.BackColor           = System.Drawing.Color.FromArgb(37, 37, 37);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text                = "Payment";
            this.Font                = new System.Drawing.Font("Segoe UI", 9F);
        }

        private void SetupMethodButton(System.Windows.Forms.Button btn, string text, int x, string tag)
        {
            btn.Text      = text;
            btn.Location  = new System.Drawing.Point(x, 0);
            btn.Height    = 68;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 58, 58);
            btn.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font      = new System.Drawing.Font("Segoe UI", 8F);
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
            btn.Tag       = tag;
            btn.Click    += new System.EventHandler(this.BtnMethod_Click);
        }
        #endregion

        private System.Windows.Forms.Panel   pnlRoot;
        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblTotalCaption;
        private System.Windows.Forms.Label   lblTotal;
        private System.Windows.Forms.Label   lblCustomerCap;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label   lblTableCap;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label   lblMethodCap;
        private System.Windows.Forms.Panel   pnlMethods;
        private System.Windows.Forms.Button  btnCash;
        private System.Windows.Forms.Button  btnGCash;
        private System.Windows.Forms.Button  btnCard;
        private System.Windows.Forms.Button  btnPayMaya;
        private System.Windows.Forms.Label   lblAmountCap;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel   pnlChange;
        private System.Windows.Forms.Label   lblChangeCap;
        private System.Windows.Forms.Label   lblChange;
        private System.Windows.Forms.Button  btnCancel;
        private System.Windows.Forms.Button  btnComplete;
    }
}
