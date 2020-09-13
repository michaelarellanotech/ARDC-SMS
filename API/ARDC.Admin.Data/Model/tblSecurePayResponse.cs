using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblSecurePayResponse
    {
        [Key]
        public int SecurePayResponseId { get; set; }
        [StringLength(100)]
        public string TeamRaceEntryId { get; set; }
        [StringLength(100)]
        public string cardtype { get; set; }
        [StringLength(100)]
        public string txnid { get; set; }
        [StringLength(100)]
        public string merchant { get; set; }
        [StringLength(100)]
        public string surfee { get; set; }
        [StringLength(100)]
        public string rescode { get; set; }
        [StringLength(100)]
        public string expirydate { get; set; }
        [StringLength(100)]
        public string baseamount { get; set; }
        [StringLength(100)]
        public string settdate { get; set; }
        [StringLength(100)]
        public string pan { get; set; }
        [StringLength(100)]
        public string currency { get; set; }
        [StringLength(100)]
        public string amount { get; set; }
        [StringLength(100)]
        public string timestamp { get; set; }
        [StringLength(100)]
        public string fingerprint { get; set; }
        [StringLength(100)]
        public string surrate { get; set; }
        [StringLength(100)]
        public string restext { get; set; }
        [StringLength(100)]
        public string suramount { get; set; }
        [StringLength(100)]
        public string refid { get; set; }
        [StringLength(100)]
        public string summarycode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
    }
}
