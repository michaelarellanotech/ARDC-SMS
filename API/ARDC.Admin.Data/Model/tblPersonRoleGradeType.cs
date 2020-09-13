using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPersonRoleGradeType
    {
        [Key]
        public int PersonRoleGradeTypeId { get; set; }
        [StringLength(10)]
        public string PersonRoleGradeType { get; set; }
        [StringLength(1)]
        public string CompetitorOrOfficial { get; set; }
        public double? SortOrder { get; set; }
    }
}
