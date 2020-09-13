using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTeamRaceEntryPayment
    {
        [Key]
        public int TeamRaceEntryPaymentId { get; set; }
        public int? TeamRaceEntryId { get; set; }
        public int? PaymentTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }
        [StringLength(50)]
        public string GatewayReceiptInfo { get; set; }
        [StringLength(50)]
        public string AccountName { get; set; }
        [StringLength(10)]
        public string ChequeBSB { get; set; }
        [StringLength(10)]
        public string ChequeAccount { get; set; }
        [StringLength(20)]
        public string CreditCardNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreditCardExpiryDate { get; set; }
        [StringLength(3)]
        public string CreditCardCode { get; set; }
        [StringLength(20)]
        public string InternalRefCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
