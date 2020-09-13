using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblCarType
    {
        [Key]
        public int CarTypeId { get; set; }
        [StringLength(255)]
        public string CarType { get; set; }
    }
}
