using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tbl_LetterTemplate
    {
        [Key]
        public int LetterTemplateId { get; set; }
        [StringLength(20)]
        public string LetterTemplateCategory { get; set; }
        public string LetterTemplate { get; set; }
        [StringLength(150)]
        public string LetterSubject { get; set; }
    }
}
