export class PagedResult {
    page: number;
    pageSize: number;
    sortBy: string;
    sortOrder: string;
    totalRecords: number;
    totalPages: number;
}

export class PagingRequest {
    page?: number;
    pageSize?: number;
    sortBy?: string;
    sortOrder?: string;
    multiSortMeta: any;

    setAsNoPaging() {
        this.page = 1;
        this.pageSize = 999999;
        this.sortBy = 'name';
        this.sortOrder = 'asc';
    }
}

export class DataFilter {
    filterBy?: string;
    value?: Array<string>;
    matchMode?: string;
}

export class FilterRequest {
    constructor() {
        this.filters = [];
    }

    search: string;
    searchMatchMode: string;
    filters: Array<DataFilter>;
    includePreviousVersions: boolean;

    addFilter(key: string, value: any) {
        const groupIdFilter = new DataFilter();
        groupIdFilter.filterBy = key;
        groupIdFilter.matchMode = 'in';
        groupIdFilter.value = [value];
        if (this.filters === null || this.filters === undefined) {
            this.filters = [];
        }
        this.filters.push(groupIdFilter);
    }

    addMultiValueFilter(key: string, values: any[]) {
        const groupIdFilter = new DataFilter();
        groupIdFilter.filterBy = key;
        groupIdFilter.matchMode = 'contains';
        groupIdFilter.value = values;
        if (this.filters === null || this.filters === undefined) {
            this.filters = [];
        }
        this.filters.push(groupIdFilter);
    }
}
