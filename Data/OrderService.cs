 using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms; 
using Newtonsoft.Json;
using BrewlyPOS.Models;

namespace BrewlyPOS.Data
{
    public static class OrderService
    {
        private static readonly string DataFolder =
     Path.Combine(Application.StartupPath, "Data");
        private static readonly string FilePath =
            Path.Combine(DataFolder, "orders.json");

        public static List<Order> LoadOrders()
        {
            try
            {
                if (!File.Exists(FilePath)) return new List<Order>();
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
            }
            catch { return new List<Order>(); }
        }

        public static void SaveOrders(List<Order> orders)
        {
            try
            {
                Directory.CreateDirectory(DataFolder);
                string json = JsonConvert.SerializeObject(orders, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }
    }
}
