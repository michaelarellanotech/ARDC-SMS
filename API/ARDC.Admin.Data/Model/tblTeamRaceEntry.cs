using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTeamRaceEntry
    {
        [Key]
        public int TeamRaceEntryId { get; set; }
        public int? TeamId { get; set; }
        public int? RaceId { get; set; }
        public int? TeamCarId { get; set; }
        public int? TeamDriverId { get; set; }
        public int? ApplicantId { get; set; }
        public int? RaceNumber { get; set; }
        public int? ClassId { get; set; }
        public int? GaragesBooked { get; set; }
        public int? CarPortsBooked { get; set; }
        public int? GaragesReserved { get; set; }
        public int? CarPortsReserved { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GaragesReservedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CarportsReservedDate { get; set; }
        public int? CarClubId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? BestLapTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
