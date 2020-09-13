using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPriceList
    {
        [Key]
        public int PriceListId { get; set; }
        public int? PriceCategoryId { get; set; }
        [StringLength(2)]
        public string PriceTier { get; set; }
        public int? EventTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(1)]
        public string MemberOrNonMember { get; set; }
        public int? RangeFrom { get; set; }
        public int? RangeTo { get; set; }
        public int? ComplimentaryCount { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? LateExtra { get; set; }
    }
}
