using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using BrewlyPOS.Data;
using BrewlyPOS.Models;

namespace BrewlyPOS.Forms
{
    public partial class InventoryForm : Form
    {
        // ── State ─────────────────────────────────────────────────────────
        private List<Product> _products;
        private Product _editing = null;
        private readonly Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        public InventoryForm(List<Product> products)
        {
            _products = products;
            InitializeComponent();
            LoadGrid();
            ShowIdleState();
        }

        // ══════════════════════════════════════════════════════════════════
        // GRID
        // ══════════════════════════════════════════════════════════════════
        private void LoadGrid()
        {
            dgv.Rows.Clear();
            foreach (var p in _products)
                dgv.Rows.Add(p.Id, p.Number, p.Name, $"₱{p.Price:0}", p.Category, p.ImageUrl);
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) return;
            var row = dgv.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["colId"].Value);
            var p = _products.Find(x => x.Id == id);
            if (p != null) OpenEditPanel(p);
        }

        // ══════════════════════════════════════════════════════════════════
        // PANEL STATE
        // ══════════════════════════════════════════════════════════════════
        private void ShowIdleState()
        {
            pnlEdit.Visible = false;
            lblHint.Visible = true;
        }

        private void OpenEditPanel(Product p)
        {
            _editing = p;
            bool isNew = (p == null);

            lblEditTitle.Text = isNew ? "➕  ADD PRODUCT" : "✏️  EDIT PRODUCT";
            txtName.Text = p?.Name ?? "";
            txtPrice.Text = p?.Price.ToString("0") ?? "";
            txtCategory.Text = p?.Category ?? "";
            txtImage.Text = p?.ImageUrl ?? "";
            picPreview.Image = null;
            btnDelete.Visible = !isNew;

            lblHint.Visible = false;
            pnlEdit.Visible = true;

            if (!isNew && !string.IsNullOrWhiteSpace(p.ImageUrl))
                LoadPreviewAsync(p.ImageUrl);
        }

        // ══════════════════════════════════════════════════════════════════
        // BUTTON HANDLERS
        // ══════════════════════════════════════════════════════════════════
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            OpenEditPanel(null);
            txtName.Focus();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            string url = txtImage.Text.Trim();
            if (!string.IsNullOrWhiteSpace(url))
                LoadPreviewAsync(url);
        }

        private async void LoadPreviewAsync(string url)
        {
            if (_imageCache.ContainsKey(url)) { picPreview.Image = _imageCache[url]; return; }
            try
            {
                using (var wc = new WebClient())
                {
                    var bytes = await wc.DownloadDataTaskAsync(url);
                    using (var ms = new MemoryStream(bytes))
                    {
                        var img = Image.FromStream(ms);
                        _imageCache[url] = img;
                        if (!picPreview.IsDisposed) picPreview.Image = img;
                    }
                }
            }
            catch { picPreview.Image = null; }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToUpper();
            string cat = txtCategory.Text.Trim().ToLower();
            string imgUrl = txtImage.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Enter a valid price (numbers only).", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editing == null)
            {
                // ADD NEW
                _products.Add(new Product
                {
                    Id = ProductData.GetNextId(_products),
                    Name = name,
                    Price = (int)price,
                    Category = cat,
                    ImageUrl = imgUrl
                });
            }
            else
            {
                // UPDATE EXISTING
                _editing.Name = name;
                _editing.Price = (int)price;
                _editing.Category = cat;
                _editing.ImageUrl = imgUrl;
            }

            ProductData.SaveProducts(_products);
            LoadGrid();
            dgv.ClearSelection();
            ShowIdleState();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_editing == null) return;
            if (MessageBox.Show($"Delete \"{_editing.Name}\"?\nThis cannot be undone.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                != DialogResult.Yes) return;

            _products.Remove(_editing);
            ProductData.SaveProducts(_products);
            _editing = null;
            LoadGrid();
            dgv.ClearSelection();
            ShowIdleState();
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            _editing = null;
            ShowIdleState();
        }
    }
}