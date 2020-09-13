using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        [StringLength(30)]
        public string PaymentType { get; set; }
    }
}
