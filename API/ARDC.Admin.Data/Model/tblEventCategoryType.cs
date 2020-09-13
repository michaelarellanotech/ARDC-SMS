using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEventCategoryType
    {
        [Key]
        public int EventCategoryTypeId { get; set; }
        public int? EventTypeId { get; set; }
        [StringLength(255)]
        public string EventCategory { get; set; }
        [StringLength(5)]
        public string Abbrev { get; set; }
        public int? CategoryManagerId { get; set; }
    }
}
