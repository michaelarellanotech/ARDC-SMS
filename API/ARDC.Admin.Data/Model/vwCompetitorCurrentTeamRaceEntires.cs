using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class vwCompetitorCurrentTeamRaceEntires
    {
        public int? TeamRaceEntryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        public int RaceId { get; set; }
        public int? BookingStatusTypeId { get; set; }
        public int EventId { get; set; }
        [StringLength(12)]
        public string EventAbbrev { get; set; }
        [StringLength(255)]
        public string EventDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventTo { get; set; }
        public int EventCategoryTypeId { get; set; }
        [StringLength(5)]
        public string EventCategoryAbbrev { get; set; }
        [StringLength(255)]
        public string EventCategory { get; set; }
        public int? ClassId { get; set; }
        [StringLength(10)]
        public string ClassAbbrev { get; set; }
        [StringLength(255)]
        public string Class { get; set; }
        public int? TeamId { get; set; }
        public int? TeamCarId { get; set; }
        public int? RaceNumber { get; set; }
        [StringLength(20)]
        public string CompetitorCAMSId { get; set; }
        public int CompetitorPersonId { get; set; }
        [StringLength(255)]
        public string CompetitorFirstName { get; set; }
        [StringLength(255)]
        public string CompetitorSurName { get; set; }
        public int driverPersonId { get; set; }
        [StringLength(20)]
        public string DriverCAMSId { get; set; }
        [StringLength(255)]
        public string DriverFirstName { get; set; }
        [StringLength(255)]
        public string DriverSurName { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountDue { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountPaid { get; set; }
    }
}
