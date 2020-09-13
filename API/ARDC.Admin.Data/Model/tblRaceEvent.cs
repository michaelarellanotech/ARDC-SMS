using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblRaceEvent
    {
        [Key]
        public int RaceEventId { get; set; }
        public int? RaceId { get; set; }
        public int? EventNo { get; set; }
        public int? DayNo { get; set; }
        public int? RaceNo { get; set; }
        public int? TrackId { get; set; }
    }
}
