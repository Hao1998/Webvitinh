using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Order
    {
        public long Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CustomerId { get; set; }
        public string ShipName { get; set; }
        public string ShipMobile { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public int? Status { get; set; }
    }
}
