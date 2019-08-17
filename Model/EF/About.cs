using System;
using System.Collections.Generic;

namespace Model
{
    public partial class About
    {
        public long Id { get; set; }
        public string MetalTitle { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool? Status { get; set; }
    }
}
