using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEvent
    {
        [Key]
        public int EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        public int? EventTypeId { get; set; }
        public int? BookingStatusTypeId { get; set; }
        [StringLength(12)]
        public string SubjectAbbrev { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OfficialEventOpen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OfficialEventClose { get; set; }
        public int? OfficialsExclude { get; set; }
        [StringLength(50)]
        public string CompetitorDisclaimer { get; set; }
    }
}
