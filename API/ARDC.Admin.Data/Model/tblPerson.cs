using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblPerson
    {
        [Key]
        public int PersonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DOB { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Suburb { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Postcode { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string HomePhone { get; set; }
        [StringLength(50)]
        public string WorkPhone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        public int? CarClubId { get; set; }
        [StringLength(10)]
        public string MemberNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MemberExpiryDate { get; set; }
        [StringLength(50)]
        public string Weight { get; set; }
        [StringLength(50)]
        public string Height { get; set; }
        [StringLength(200)]
        public string NextOfKin { get; set; }
        public short? ChiefAccess { get; set; }
        [StringLength(50)]
        public string Relationship { get; set; }
        [StringLength(200)]
        public string NextofKinAddress { get; set; }
        [StringLength(50)]
        public string NextOfKinHomePhone { get; set; }
        [StringLength(50)]
        public string NextOfKinWorkPhone { get; set; }
        [StringLength(50)]
        public string NextOfKinMobile { get; set; }
        [StringLength(200)]
        public string GeneralPractitioner { get; set; }
        [StringLength(200)]
        public string AddressOfGP { get; set; }
        [StringLength(50)]
        public string PhoneOfGP { get; set; }
        [StringLength(20)]
        public string BloodGroup { get; set; }
        public string MedicationPrescribed { get; set; }
        public string Allergies { get; set; }
        public string MedicalConditions { get; set; }
        public string BrokenBones { get; set; }
        [StringLength(50)]
        public string LastTetinusInjection { get; set; }
        public string AnythingRelevant { get; set; }
        [StringLength(255)]
        public string Signature { get; set; }
        [StringLength(255)]
        public string SignatureDate { get; set; }
        public string Comments { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? HasCAMSId { get; set; }
        public bool InTraining { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VenueInductionAcknowledgedDateTime { get; set; }
        [StringLength(50)]
        public string DoYouSmoke { get; set; }
        [StringLength(15)]
        public string WWCNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WWCStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WWCExpiry { get; set; }
    }
}
