using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblRace
    {
        [Key]
        public int RaceId { get; set; }
        public int? EventDayId { get; set; }
        public int? Sequence { get; set; }
        public int? EventCategoryTypeId { get; set; }
        public short? MinDrivers { get; set; }
        public short? MaxDrivers { get; set; }
        [StringLength(2)]
        public string PriceTier { get; set; }
    }
}
