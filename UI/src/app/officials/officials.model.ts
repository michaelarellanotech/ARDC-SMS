import { PagedResult } from 'src/app/common/paging/pagedresult.model';

export class OfficialListItem {
    constructor(
    public eventType: string,
    public eventDay: Date,
    public surname: string,
    public firstname: string,
    public personRoleType: string,
    public personRoleGradeType: string) {}
}

export class OfficialsPagedList extends PagedResult {
    result: OfficialListItem[];
}
