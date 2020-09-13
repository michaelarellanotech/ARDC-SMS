using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTeamRaceEntryGarageCarPort
    {
        [Key]
        public int TeamRaceEntryGarageCarPortId { get; set; }
        public int? TeamRaceEntryId { get; set; }
        public int? GarageCarPortId { get; set; }
        public double? Seq { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
