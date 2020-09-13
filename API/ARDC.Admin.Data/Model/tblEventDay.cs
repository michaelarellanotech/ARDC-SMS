using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEventDay
    {
        [Key]
        public int EventDayId { get; set; }
        public int? EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDay { get; set; }
    }
}
