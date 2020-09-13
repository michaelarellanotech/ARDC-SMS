using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tempOfficialsMigration
    {
        public int PersonId { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [StringLength(3)]
        public string IsCompetitorOrDriver { get; set; }
        [StringLength(3)]
        public string ASPUserExists { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [Required]
        [StringLength(3)]
        public string WillBeMigrated { get; set; }
        [StringLength(10)]
        public string NewPassword { get; set; }
    }
}
