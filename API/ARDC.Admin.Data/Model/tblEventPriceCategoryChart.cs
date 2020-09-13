using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARDC.Admin.Data.Model
{
    public partial class tblEventPriceCategoryChart
    {
        public int EventPriceCategoryChartId { get; set; }
        public int? EventTypeId { get; set; }
        public int? PriceCategoryId { get; set; }
        [StringLength(10)]
        public string ChartNo { get; set; }
    }
}
