using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblCarClub
    {
        [Key]
        public int CarClubId { get; set; }
        [StringLength(50)]
        public string CarClub { get; set; }
        public double? SortOrder { get; set; }
    }
}
