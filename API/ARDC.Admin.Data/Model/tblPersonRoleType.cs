using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPersonRoleType
    {
        [Key]
        public int PersonRoleTypeId { get; set; }
        [StringLength(255)]
        public string RoleClass { get; set; }
        [StringLength(255)]
        public string PersonRoleType { get; set; }
        [StringLength(255)]
        public string PersonRoleTypeCorrect { get; set; }
        public int? InitialLoadCount { get; set; }
        public float? ProgramSeq { get; set; }
    }
}
