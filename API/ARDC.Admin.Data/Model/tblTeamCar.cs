using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblTeamCar
    {
        [Key]
        public int TeamCarId { get; set; }
        public int? CarId { get; set; }
        public int? TeamId { get; set; }
    }
}
