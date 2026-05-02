using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrewlyPOS.Forms
{
    public partial class PaymentForm : Form
    {
        private decimal _total;
        private string  _selectedMethod = "Cash";

        public string  ResultCustomer      { get; private set; } = "Guest";
        public string  ResultTable         { get; private set; } = "-";
        public string  ResultPaymentMethod { get; private set; } = "Cash";
        public decimal ResultPayment       { get; private set; }
        public decimal ResultChange        { get; private set; }

        public PaymentForm(decimal total, string currentTable)
        {
            InitializeComponent();
            _total         = total;
            lblTotal.Text  = $"₱{total:0.00}";
            txtTable.Text  = currentTable;
            HighlightMethod("Cash");
        }

        private void BtnMethod_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                _selectedMethod = btn.Tag?.ToString() ?? "Cash";
                HighlightMethod(_selectedMethod);
            }
        }

        private void HighlightMethod(string method)
        {
            foreach (Button btn in new[] { btnCash, btnGCash, btnCard, btnPayMaya })
            {
                bool sel = btn.Tag?.ToString() == method;
                btn.BackColor = sel ? Color.FromArgb(255, 140, 66) : Color.FromArgb(13, 13, 13);
                btn.FlatAppearance.BorderColor = sel
                    ? Color.FromArgb(255, 140, 66)
                    : Color.FromArgb(58, 58, 58);
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal payment))
            {
                decimal change = payment - _total;
                if (change >= 0)
                {
                    lblChange.Text      = $"₱{change:0.00}";
                    lblChange.ForeColor = Color.FromArgb(76, 175, 80);
                    btnComplete.Enabled   = true;
                    btnComplete.BackColor = Color.FromArgb(255, 140, 66);
                    btnComplete.ForeColor = Color.White;
                }
                else
                {
                    lblChange.Text      = $"₱{Math.Abs(change):0.00} short";
                    lblChange.ForeColor = Color.FromArgb(255, 68, 68);
                    btnComplete.Enabled   = false;
                    btnComplete.BackColor = Color.FromArgb(37, 37, 37);
                    btnComplete.ForeColor = Color.FromArgb(176, 176, 176);
                }
            }
            else
            {
                lblChange.Text      = "₱0.00";
                btnComplete.Enabled = false;
            }
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal payment)) return;

            ResultCustomer      = string.IsNullOrWhiteSpace(txtCustomer.Text) ? "Guest" : txtCustomer.Text.Trim();
            ResultTable         = string.IsNullOrWhiteSpace(txtTable.Text)    ? "-"     : txtTable.Text.Trim();
            ResultPaymentMethod = _selectedMethod;
            ResultPayment       = payment;
            ResultChange        = payment - _total;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
