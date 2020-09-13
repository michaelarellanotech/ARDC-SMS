using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTeamRaceEntryPriceItem
    {
        [Key]
        public int TeamRaceEntryPriceItemId { get; set; }
        public int? TeamRaceEntryId { get; set; }
        public int? PriceCategoryId { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Ordered { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Dispatched { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
