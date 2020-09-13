using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblCar
    {
        [Key]
        public int CarId { get; set; }
        public int? CarTypeId { get; set; }
        [StringLength(255)]
        public string Car { get; set; }
        public int? CarYear { get; set; }
        [StringLength(50)]
        public string MakeModel { get; set; }
        [StringLength(50)]
        public string Colour { get; set; }
        [StringLength(50)]
        public string EngineType { get; set; }
        [StringLength(50)]
        public string Capacity { get; set; }
        [StringLength(50)]
        public string LogBookNo { get; set; }
        [StringLength(15)]
        public string RegNo { get; set; }
        [StringLength(50)]
        public string Dorian { get; set; }
        public int? RaceNumber { get; set; }
        public short? Cameras { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
