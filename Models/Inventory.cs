﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesTracker.Models
{
    [Table("Inventories")]
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public string Item { get; set; }
        public int Cost { get; set; }
        public int SalePrice { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ApplicationUser User { get; set; }
        public Inventory(string item, int cost, int salePrice, int inventoryId = 0)
        {
            Item = item;
            Cost = cost;
            SalePrice = salePrice;
            InventoryId = inventoryId;
        }

        public Inventory()
        {
        }
    }
}
