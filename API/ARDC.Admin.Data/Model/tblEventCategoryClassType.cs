using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEventCategoryClassType
    {
        [Key]
        public int EventCategoryClassTypeId { get; set; }
        public int? EventCategoryTypeId { get; set; }
        public int? Sequence { get; set; }
        [StringLength(10)]
        public string ClassAbbrev { get; set; }
        [StringLength(255)]
        public string Class { get; set; }
    }
}
