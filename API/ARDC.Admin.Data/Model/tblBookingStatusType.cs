using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblBookingStatusType
    {
        [Key]
        public int BookingStatusTypeId { get; set; }
        [StringLength(10)]
        public string BookingStatusType { get; set; }
    }
}
