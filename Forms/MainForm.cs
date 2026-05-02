using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using BrewlyPOS.Data;
using BrewlyPOS.Models;

namespace BrewlyPOS.Forms
{
    public partial class MainForm : Form
    {
        // ── State ────────────────────────────────────────────────────────
        private List<Product>  _products = new List<Product>();
        private List<CartItem> _cart     = new List<CartItem>();
        private List<Order>    _history  = new List<Order>();
        private Order          _lastOrder;

        // Image cache to avoid re-downloading
        private readonly Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        public MainForm()
        {
            InitializeComponent();
          
            LoadData();
        }

        private void LoadData()
        {
            _products = ProductData.GetProducts();
            _history  = OrderService.LoadOrders();
            RenderProducts();
            RefreshCartUI();
            ClockTimer_Tick(null, null);
        }

        // ── Clock ─────────────────────────────────────────────────────────
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("ddd, MMM d, yyyy\nhh:mm:ss tt");
        }

        // ── Tabs ──────────────────────────────────────────────────────────
        private void BtnTabOrder_Click(object sender, EventArgs e)   => ShowTab(true);
        private void BtnTabHistory_Click(object sender, EventArgs e) => ShowTab(false);
        private void BtnHistorySidebar_Click(object sender, EventArgs e) => ShowTab(false);

        private void ShowTab(bool isOrder)
        {
            flpProducts.Visible  =  isOrder;
            pnlHistory.Visible   = !isOrder;
            btnTabOrder.ForeColor   = isOrder ? Color.FromArgb(255,140,66) : Color.FromArgb(176,176,176);
            btnTabHistory.ForeColor = isOrder ? Color.FromArgb(176,176,176) : Color.FromArgb(255,140,66);
            pnlTabLine.Left         = isOrder ? 0 : 150;
            pnlTabLine.Width        = isOrder ? 150 : 140;
            if (!isOrder) RenderHistory();
        }

        // ── Products ──────────────────────────────────────────────────────
        private void RenderProducts()
        {
            flpProducts.Controls.Clear();
            foreach (var p in _products)
                flpProducts.Controls.Add(CreateProductCard(p));
        }

        private Panel CreateProductCard(Product p)
        {
            var card = new Panel
            {
                Width     = 170,
                Height    = 190,
                BackColor = Color.FromArgb(37, 37, 37),
                Margin    = new Padding(0, 0, 14, 14),
                Cursor    = Cursors.Hand,
                Tag       = p
            };

            // Number badge
            var badge = new Label
            {
                Text      = p.Number.ToString(),
                Size      = new Size(24, 24),
                Location  = new Point(10, 10),
                Font      = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(60, 255, 255, 255),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Product image
            var pic = new PictureBox
            {
                Location  = new Point(10, 10),
                Size      = new Size(150, 100),
                SizeMode  = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(37, 37, 37)
            };
            LoadImageAsync(p.ImageUrl, pic);

            // Name
            var name = new Label
            {
                Text      = p.Name,
                Location  = new Point(5, 115),
                Size      = new Size(160, 22),
                Font      = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Price
            var price = new Label
            {
                Text      = $"₱{p.Price:0}",
                Location  = new Point(5, 138),
                Size      = new Size(160, 20),
                Font      = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(176, 176, 176),
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.AddRange(new Control[] { pic, badge, name, price });

            // Click anywhere on card to add to cart
            EventHandler addHandler = (s, e) => AddToCart(p);
            card.Click += addHandler;
            foreach (Control c in card.Controls) c.Click += addHandler;

            // Hover highlight
            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(45, 45, 45);
            card.MouseLeave += (s, e) => card.BackColor = Color.FromArgb(37, 37, 37);

            return card;
        }

        private async void LoadImageAsync(string url, PictureBox pic)
        {
            if (_imageCache.ContainsKey(url)) { pic.Image = _imageCache[url]; return; }
            try
            {
                using (var wc = new WebClient())
                {
                    var bytes = await wc.DownloadDataTaskAsync(url);
                    using (var ms = new MemoryStream(bytes))
                    {
                        var img = Image.FromStream(ms);
                        _imageCache[url] = img;
                        if (!pic.IsDisposed) pic.Image = img;
                    }
                }
            }
            catch { /* use placeholder */ }
        }

        // ── Cart ──────────────────────────────────────────────────────────
        private void AddToCart(Product p)
        {
            var existing = _cart.FirstOrDefault(i => i.Id == p.Id);
            if (existing != null) existing.Qty++;
            else _cart.Add(new CartItem { Id = p.Id, Name = p.Name, Price = p.Price, ImageUrl = p.ImageUrl, Qty = 1 });
            RefreshCartUI();
        }

        private void ChangeQty(CartItem item, int delta)
        {
            item.Qty += delta;
            if (item.Qty <= 0) _cart.Remove(item);
            RefreshCartUI();
        }

        private void RemoveFromCart(CartItem item)
        {
            _cart.Remove(item);
            RefreshCartUI();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            if (MessageBox.Show("Clear all items from the order?", "Clear Cart",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _cart.Clear();
                RefreshCartUI();
            }
        }

        private void RefreshCartUI()
        {
            flpCart.SuspendLayout();
            flpCart.Controls.Clear();

            bool hasItems = _cart.Count > 0;
            lblEmptyCart.Visible = !hasItems;
            btnConfirm.Enabled   =  hasItems;

            if (hasItems)
            {
                btnConfirm.BackColor = Color.FromArgb(255, 140, 66);
                btnConfirm.ForeColor = Color.White;
            }
            else
            {
                btnConfirm.BackColor = Color.FromArgb(37, 37, 37);
                btnConfirm.ForeColor = Color.FromArgb(176, 176, 176);
            }

            foreach (var item in _cart)
                flpCart.Controls.Add(CreateCartRow(item));

            decimal total   = _cart.Sum(i => i.Price * i.Qty);
            lblTotal.Text   = $"₱{total:0.00}";

            flpCart.ResumeLayout();
        }

        private Panel CreateCartRow(CartItem item)
        {
            var row = new Panel
            {
                Width     = 340,
                Height    = 68,
                BackColor = Color.FromArgb(37, 37, 37),
                Margin    = new Padding(0, 0, 0, 8)
            };

            var pic = new PictureBox
            {
                Location = new Point(8, 8),
                Size     = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor= Color.FromArgb(37, 37, 37)
            };
            LoadImageAsync(item.ImageUrl, pic);

            var lblName = new Label
            {
                Text      = item.Name,
                Location  = new Point(66, 8),
                Size      = new Size(160, 20),
                Font      = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White
            };

            var lblPrice = new Label
            {
                Text      = $"₱{item.Price:0} × {item.Qty}",
                Location  = new Point(66, 28),
                Size      = new Size(160, 18),
                Font      = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(176, 176, 176)
            };

            var btnMinus = MakeQtyBtn("−", new Point(235, 20));
            btnMinus.Click += (s, e) => { ChangeQty(item, -1); };

            var lblQty = new Label
            {
                Text      = item.Qty.ToString(),
                Location  = new Point(263, 22),
                Size      = new Size(22, 22),
                Font      = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Tag       = item
            };

            var btnPlus = MakeQtyBtn("+", new Point(284, 20));
            btnPlus.Click += (s, e) => { ChangeQty(item, 1); };

            var btnRemove = new Button
            {
                Text      = "×",
                Location  = new Point(312, 20),
                Size      = new Size(24, 24),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 68, 68),
                ForeColor = Color.White,
                Cursor    = Cursors.Hand
            };
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Click += (s, e) => { RemoveFromCart(item); };

            row.Controls.AddRange(new Control[] { pic, lblName, lblPrice, btnMinus, lblQty, btnPlus, btnRemove });
            return row;
        }

        private Button MakeQtyBtn(string text, Point loc)
        {
            var b = new Button
            {
                Text      = text,
                Location  = loc,
                Size      = new Size(24, 24),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(13, 13, 13),
                ForeColor = Color.White,
                Cursor    = Cursors.Hand
            };
            b.FlatAppearance.BorderColor = Color.FromArgb(58, 58, 58);
            return b;
        }

        // ── Confirm / Payment ─────────────────────────────────────────────
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            decimal total = _cart.Sum(i => i.Price * i.Qty);
            using (var dlg = new PaymentForm(total, txtTable.Text))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var order = new Order
                    {
                        OrderNumber   = _history.Count + 1,
                        Date          = DateTime.Now,
                        Customer      = dlg.ResultCustomer,
                        Table         = dlg.ResultTable,
                        PaymentMethod = dlg.ResultPaymentMethod,
                        Total         = total,
                        Payment       = dlg.ResultPayment,
                        Change        = dlg.ResultChange,
                        Items         = _cart.Select(i => new OrderItem
                        {
                            Name     = i.Name,
                            Qty      = i.Qty,
                            Price    = i.Price,
                            Subtotal = i.Price * i.Qty
                        }).ToList()
                    };

                    _history.Add(order);
                    OrderService.SaveOrders(_history);
                    _lastOrder  = order;
                    txtTable.Text = dlg.ResultTable;
                    _cart.Clear();
                    RefreshCartUI();

                    MessageBox.Show(
                        $"Order Complete!\n\nOrder #{order.OrderNumber}\n" +
                        $"Total:   ₱{total:0.00}\n" +
                        $"Payment: ₱{order.Payment:0.00}\n" +
                        $"Change:  ₱{order.Change:0.00}",
                        "Sale Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ── Print ─────────────────────────────────────────────────────────
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (_lastOrder == null)
            {
                MessageBox.Show("No recent order to print. Complete a sale first.",
                                "No Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Save receipt as a text file to Desktop?", "Print Receipt",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SaveReceiptText(_lastOrder);
        }

        private void SaveReceiptText(Order o)
        {
            var lines = new List<string>
            {
                "================================",
                "        BREWLY COFFEE           ",
                "   Thank you for your order!    ",
                "================================",
                $"Order #:  {o.OrderNumber}",
                $"Date:     {o.Date:g}",
                $"Table:    {o.Table}",
                $"Customer: {o.Customer}",
                $"Payment:  {o.PaymentMethod}",
                "--------------------------------"
            };
            foreach (var item in o.Items)
                lines.Add($"{item.Name} x{item.Qty}".PadRight(22) + $"₱{item.Subtotal:0.00}");
            lines.AddRange(new[]
            {
                "================================",
                "TOTAL:  ".PadRight(22)   + $"₱{o.Total:0.00}",
                "PAYMENT:".PadRight(22)   + $"₱{o.Payment:0.00}",
                "CHANGE: ".PadRight(22)   + $"₱{o.Change:0.00}",
                "================================",
                "        Have a great day!       ",
                "================================"
            });
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Receipt_Order_{o.OrderNumber}.txt");
            File.WriteAllLines(path, lines);
            MessageBox.Show($"Receipt saved to Desktop:\n{Path.GetFileName(path)}",
                            "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(path);
        }

        // ── History ───────────────────────────────────────────────────────
        private void RenderHistory()
        {
            flpHistory.Controls.Clear();
            var reversed = _history.AsEnumerable().Reverse().ToList();
            if (reversed.Count == 0)
            {
                flpHistory.Controls.Add(new Label
                {
                    Text      = "No order history yet",
                    Font      = new Font("Segoe UI", 11F),
                    ForeColor = Color.FromArgb(176, 176, 176),
                    AutoSize  = true,
                    Margin    = new Padding(10, 20, 0, 0)
                });
                return;
            }
            foreach (var order in reversed)
                flpHistory.Controls.Add(CreateHistoryCard(order));
        }

        private Panel CreateHistoryCard(Order o)
        {
            int cardW = flpHistory.ClientSize.Width - 40;
            if (cardW < 400) cardW = 400;

            var card = new Panel
            {
                Width     = cardW,
                AutoSize  = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.FromArgb(37, 37, 37),
                Margin    = new Padding(0, 0, 0, 15),
                Padding   = new Padding(15)
            };

            var inner = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                WrapContents  = false,
                AutoSize      = true,
                AutoSizeMode  = AutoSizeMode.GrowAndShrink,
                Dock          = DockStyle.Fill,
                BackColor     = Color.Transparent,
                Padding       = new Padding(0)
            };

            // Header row
            var hdrPanel = new Panel { Width = cardW - 30, Height = 30, BackColor = Color.Transparent };
            var lblNum = new Label
            {
                Text      = $"Order #{o.OrderNumber}",
                Font      = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 140, 66),
                AutoSize  = true,
                Location  = new Point(0, 4)
            };
            var lblDate = new Label
            {
                Text      = o.Date.ToString("g"),
                Font      = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(176, 176, 176),
                AutoSize  = true,
                Anchor    = AnchorStyles.Right | AnchorStyles.Top,
                Location  = new Point(cardW - 200, 8)
            };
            hdrPanel.Controls.AddRange(new Control[] { lblNum, lblDate });
            inner.Controls.Add(hdrPanel);

            // Separator
            inner.Controls.Add(new Panel { Width = cardW - 30, Height = 1, BackColor = Color.FromArgb(58, 58, 58), Margin = new Padding(0, 4, 0, 8) });

            // Details
            var details = $"Table: {o.Table}   |   Customer: {o.Customer}   |   Payment: {o.PaymentMethod}   |   Change: ₱{o.Change:0.00}";
            inner.Controls.Add(new Label
            {
                Text      = details,
                Font      = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(176, 176, 176),
                AutoSize  = true,
                Margin    = new Padding(0, 0, 0, 8)
            });

            // Items
            foreach (var item in o.Items)
            {
                var row = new Panel { Width = cardW - 30, Height = 22, BackColor = Color.Transparent };
                row.Controls.Add(new Label { Text = $"{item.Name} x{item.Qty}", Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(176,176,176), AutoSize = true, Location = new Point(0, 2) });
                var priceL = new Label { Text = $"₱{item.Subtotal:0.00}", Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(176,176,176), AutoSize = true };
                priceL.Location = new Point(cardW - 100, 2);
                row.Controls.Add(priceL);
                inner.Controls.Add(row);
            }

            // Total
            inner.Controls.Add(new Panel { Width = cardW - 30, Height = 1, BackColor = Color.FromArgb(58, 58, 58), Margin = new Padding(0, 8, 0, 8) });
            inner.Controls.Add(new Label
            {
                Text      = $"Total: ₱{o.Total:0.00}",
                Font      = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 140, 66),
                AutoSize  = true,
                Margin    = new Padding(0, 0, 0, 4)
            });

            card.Controls.Add(inner);
            return card;
        }

        // ── Excel / CSV Export ────────────────────────────────────────────
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (_history.Count == 0)
            {
                MessageBox.Show("No orders to export.", "No Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Brewly_Orders_{DateTime.Now:yyyy-MM-dd}.csv");
            using (var w = new StreamWriter(path))
            {
                w.WriteLine("Order #,Date,Time,Table,Customer,Payment Method,Items,Total,Payment,Change");
                foreach (var o in _history)
                {
                    var items = string.Join(" | ", o.Items.Select(i => $"{i.Name} x{i.Qty}"));
                    w.WriteLine($"{o.OrderNumber},{o.Date:yyyy-MM-dd},{o.Date:HH:mm:ss}," +
                                $"\"{o.Table}\",\"{o.Customer}\",{o.PaymentMethod}," +
                                $"\"{items}\",{o.Total:0.00},{o.Payment:0.00},{o.Change:0.00}");
                }
            }
            MessageBox.Show($"Exported to Desktop:\n{Path.GetFileName(path)}",
                            "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(path);
        }

        // ── Inventory ─────────────────────────────────────────────────────
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            using (var inv = new InventoryForm(_products))
            {
                inv.ShowDialog(this);
                _imageCache.Clear();
                _products = ProductData.GetProducts();
                RenderProducts();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
