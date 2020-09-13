using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPersonRole
    {
        [Key]
        public int PersonRoleId { get; set; }
        public int? PersonId { get; set; }
        public int? PersonRoleTypeId { get; set; }
        [StringLength(20)]
        public string LicenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenceExpiry { get; set; }
        public int? PersonRoleGradeTypeId { get; set; }
        [StringLength(20)]
        public string RegularityLicenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
