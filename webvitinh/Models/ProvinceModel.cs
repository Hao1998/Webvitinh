using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webvitinh.Models
{
    public class ProvinceModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }

    public class Container
    {
        public ProvinceModel[] Provineces { set; get; }
    }
}