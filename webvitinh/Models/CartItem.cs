using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webvitinh.Models
{
    public class CartItem
    {
        public Product Product { set; get; }
        public int Quantity { set; get; }
    }
}
