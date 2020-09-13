using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class ELMAH_Error
    {
        [Key]
        public Guid ErrorId { get; set; }
        [Required]
        [StringLength(60)]
        public string Application { get; set; }
        [Required]
        [StringLength(50)]
        public string Host { get; set; }
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        [Required]
        [StringLength(60)]
        public string Source { get; set; }
        [Required]
        [StringLength(500)]
        public string Message { get; set; }
        [Required]
        [StringLength(50)]
        public string User { get; set; }
        public int StatusCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeUtc { get; set; }
        public int Sequence { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string AllXml { get; set; }
    }
}
