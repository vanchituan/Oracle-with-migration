﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModel.Admin.Order
{
    public class ItemViewModel
    {
        public int? OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CustomerName { get; set; }
        public string ShipName { get; set; }
        public string ShipMobile { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public decimal Total { get; set; }
        public int? PromotionId { get; set; }
        public string PromotionName { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public int Discount { get; set; }
        public List<CartDetailViewModel> CartList { get; set; }
    }
}
