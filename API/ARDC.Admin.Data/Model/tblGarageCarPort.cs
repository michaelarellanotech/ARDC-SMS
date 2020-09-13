using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblGarageCarPort
    {
        [Key]
        public int GarageCarportId { get; set; }
        [StringLength(6)]
        public string Abbrev { get; set; }
        [StringLength(15)]
        public string Description { get; set; }
    }
}
