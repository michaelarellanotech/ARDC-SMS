using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblLookup
    {
        [Key]
        public int LookupId { get; set; }
        [StringLength(255)]
        public string LookupType { get; set; }
        [StringLength(255)]
        public string LookupValue { get; set; }
        public int? InitialLookupCount { get; set; }
    }
}
