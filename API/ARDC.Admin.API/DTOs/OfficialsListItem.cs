using System;

namespace ARDC.Admin.API.DTOs
{
    public class OfficialsListItem
    {
        public string EventType { get; set; }
        public DateTime? EventDay { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string PersonRoleType { get; set; }
        public string PersonRoleGradeType { get; set; }
    }
}
