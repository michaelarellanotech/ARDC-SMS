using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblSystemConfig
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FieldName { get; set; }
        [Required]
        public string FieldValue { get; set; }
        [StringLength(50)]
        public string FieldType { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDateTime { get; set; }
        public int UpdatedBy { get; set; }
    }
}
