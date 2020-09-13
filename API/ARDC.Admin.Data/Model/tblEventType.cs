using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEventType
    {
        [Key]
        public int EventTypeId { get; set; }
        [StringLength(255)]
        public string EventType { get; set; }
    }
}
