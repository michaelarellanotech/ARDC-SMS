using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class vwCompetitorCurrentRaceEntries
    {
        public int TeamRaceEntryId { get; set; }
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
        [StringLength(20)]
        public string CompetitorCAMSId { get; set; }
        public int CompetitorPersonId { get; set; }
        [StringLength(255)]
        public string CompetitorFirstName { get; set; }
        [StringLength(255)]
        public string CompetitorSurName { get; set; }
        public int Driver1PersonId { get; set; }
        [StringLength(20)]
        public string Driver1CAMSId { get; set; }
        [StringLength(255)]
        public string Driver1FirstName { get; set; }
        [StringLength(255)]
        public string Driver1SurName { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountDue { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountPaid { get; set; }
        public int? Driver2PersonId { get; set; }
        [StringLength(20)]
        public string Driver2CAMSId { get; set; }
        [StringLength(255)]
        public string Driver2FirstName { get; set; }
        [StringLength(255)]
        public string Driver2SurName { get; set; }
    }
}
