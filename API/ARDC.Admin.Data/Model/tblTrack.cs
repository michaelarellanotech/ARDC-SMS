using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTrack
    {
        [Key]
        public int TrackId { get; set; }
        [StringLength(50)]
        public string TrackName { get; set; }
        public float? TrackLength { get; set; }
    }
}
