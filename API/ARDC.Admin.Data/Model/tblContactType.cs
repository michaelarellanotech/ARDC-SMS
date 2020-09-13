using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblContactType
    {
        [Key]
        public int ContactTypeId { get; set; }
        [StringLength(255)]
        public string ContactType { get; set; }
    }
}
