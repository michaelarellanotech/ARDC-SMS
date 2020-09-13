using ARDC.Admin.API.DTOs;
using Models = ARDC.Admin.Data.Model;

namespace ARDC.Admin.API.Extensions
{
    public static class OfficialsExtension
    {
        public static OfficialsListItem ToDto(this Models.vwOfficialsEventDay source) => source == null
               ? null
               : new OfficialsListItem
               {
                   EventType = source.EventType,
                   EventDay = source.EventDay,
                   Surname = source.Surname,
                   Firstname = source.Firstname,
                   PersonRoleType = source.PersonRoleType,
                   PersonRoleGradeType = source.PersonRoleGradeType,
               };

    }
}


