using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace webvitinh.Areas.Admin.Models
{
    public class ContentCreateViewModel
    {
        public long Id { get; set; }
        public string MetalTitle { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public long? CategoryId { get; set; }
        public string Detail { get; set; }
        public int? Warranty { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public DateTime? TopHot { get; set; }
        public int? Viewcount { get; set; }
        public string Tags { get; set; }
        public string Language { get; set; }
    }
}
