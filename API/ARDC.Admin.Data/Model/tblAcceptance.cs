using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblAcceptance
    {
        [Key]
        public int AcceptanceId { get; set; }
        [Required]
        [StringLength(50)]
        public string AcceptanceType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AcceptedDateTime { get; set; }
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }
        [Required]
        [StringLength(1000)]
        public string DocumentReference { get; set; }
        public int ReferenceNumber { get; set; }
    }
}
