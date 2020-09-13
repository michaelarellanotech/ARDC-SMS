using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class vwOfficialsEventDay
    {
        [StringLength(255)]
        public string EventType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDay { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [StringLength(255)]
        public string PersonRoleType { get; set; }
        [StringLength(10)]
        public string PersonRoleGradeType { get; set; }
    }
}
