using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Menus
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public int? DisplayOrder { get; set; }
        public string Target { get; set; }
        public bool? Status { get; set; }
        public int? TypeId { get; set; }
    }
}
