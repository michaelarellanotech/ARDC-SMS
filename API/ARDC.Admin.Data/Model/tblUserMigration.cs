using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblUserMigration
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        [Required]
        [StringLength(200)]
        public string PersonName { get; set; }
        [Required]
        [StringLength(50)]
        public string CAMS { get; set; }
        [Required]
        [StringLength(50)]
        public string NewPassword { get; set; }
        public bool? MemberCreated { get; set; }
        [StringLength(200)]
        public string ErrorMessage { get; set; }
        public bool PasswordChangeRequired { get; set; }
        public bool IsEntrant { get; set; }
        [StringLength(100)]
        public string DriverLicence { get; set; }
        public bool IsDriver { get; set; }
        [StringLength(100)]
        public string EntrantLicence { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDateTime { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsOfficial { get; set; }
        [StringLength(100)]
        public string OfficialLicence { get; set; }
    }
}
