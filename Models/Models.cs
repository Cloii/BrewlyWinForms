using System;
using System.Collections.Generic;

namespace BrewlyPOS.Models
{
    public class Product
    {
        public int     Id       { get; set; }
        public int     Number   { get; set; }
        public string  Name     { get; set; }
        public decimal Price    { get; set; }
        public string  Category { get; set; }
        public string  ImageUrl { get; set; }
    }

    public class CartItem
    {
        public int     Id       { get; set; }
        public string  Name     { get; set; }
        public decimal Price    { get; set; }
        public string  ImageUrl { get; set; }
        public int     Qty      { get; set; }
        public decimal Subtotal => Price * Qty;
    }

    public class OrderItem
    {
        public string  Name     { get; set; }
        public int     Qty      { get; set; }
        public decimal Price    { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class Order
    {
        public int     OrderNumber    { get; set; }
        public DateTime Date          { get; set; }
        public string  Customer       { get; set; }
        public string  Table          { get; set; }
        public string  PaymentMethod  { get; set; }
        public List<OrderItem> Items  { get; set; } = new List<OrderItem>();
        public decimal Total          { get; set; }
        public decimal Payment        { get; set; }
        public decimal Change         { get; set; }
    }
}
