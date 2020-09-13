using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblGarageCarportNonAvailability
    {
        [Key]
        public int GarageCarportNonAvailabilityId { get; set; }
        public int? GarageCarportId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NotAvailableFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NotAvailableTo { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
    }
}
