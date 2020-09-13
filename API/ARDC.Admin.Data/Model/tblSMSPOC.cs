using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblSMSPOC
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(50)]
        public string CAMS { get; set; }
        [StringLength(50)]
        public string DOB { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string RaceEvent { get; set; }
        [StringLength(50)]
        public string EventDateTime { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(50)]
        public string SMSSent { get; set; }
        public string SMSSentLog { get; set; }
        [StringLength(50)]
        public string SMSResponse { get; set; }
        public string SMSResponseLog { get; set; }
    }
}
