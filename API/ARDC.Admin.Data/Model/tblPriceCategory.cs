using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPriceCategory
    {
        [Key]
        public int PriceCategoryId { get; set; }
        public int? Seq { get; set; }
        [StringLength(255)]
        public string PriceCategory { get; set; }
        public bool IsMerchandise { get; set; }
        public bool IsAvailable { get; set; }
        [StringLength(15)]
        public string Abbrev { get; set; }
    }
}
