import { Router } from '@angular/router';
import { LazyLoadEvent } from 'primeng/api';
import { map, finalize } from 'rxjs/operators';
import { Table } from 'primeng/table';
import { SortOrder } from './constants';
import { DataFilter } from './paging/DataFilter';
import { PagingRequest, FilterRequest } from './paging/PagedResult.model';
import { Injector } from '@angular/core';
//import { BlockUIService } from '../services/blockUI.service';

export class ListPageBase {
  page = 1; // pages numeration starts with 1
  pageSize = 10;
  pageCount: number;
  sortBy = '';
  sortOrder = '';
  totalRecords: number;
  loadCompleted = false;
  listData: any[] = [];
  searchString = '';
  selectedRecord: any;
  pageOffset = 0;
  dataService: any;
  mytable: Table;
  //blockUIService: BlockUIService;

  constructor(public injector: Injector) {
    //this.blockUIService = this.injector.get(BlockUIService);
  }

  get totalPages(): number {
    if (this.mytable && this.mytable.totalRecords) {
      return Math.ceil(this.mytable.totalRecords / this.mytable.rows);
    }
    return 0;
  }

  loadListDataLazy(loadEvent: LazyLoadEvent) {
    // Always reset to first page when pageSize is changed.
    if (this.pageSize !== loadEvent.rows) {
      this.pageOffset = 0;
      this.page = 1;
    } else {
      this.pageOffset = loadEvent.first;
      this.page = this.convertOffsetToPage(loadEvent.first);
    }

    this.pageSize = loadEvent.rows;
    this.sortBy = loadEvent.sortField ? loadEvent.sortField : this.sortBy;
    this.sortOrder = loadEvent.sortOrder === 1 ? SortOrder.Asc : SortOrder.Desc;

    // populate paging request
    const pagingReq: PagingRequest = new PagingRequest();
    pagingReq.pageSize = this.pageSize;
    pagingReq.page = this.page;
    pagingReq.sortBy = this.sortBy;
    pagingReq.sortOrder = this.sortOrder;

    let filterReq: FilterRequest = null;
    // populate filtering request
    if (loadEvent.filters || loadEvent.globalFilter) {
      filterReq = new FilterRequest();
      filterReq.search = loadEvent.globalFilter;

      filterReq.filters = new Array<DataFilter>();
      let filter: DataFilter;
      for (const fld in loadEvent.filters) {
        if (loadEvent.filters.hasOwnProperty(fld)) {
          filter = new DataFilter();
          filter.filterBy = fld;
          filter.matchMode = loadEvent.filters[fld].matchMode;
          filter.value = new Array();

          if (Array.isArray(loadEvent.filters[fld].value)) {
            let index;
            for (index in loadEvent.filters[fld].value) {
              if (loadEvent.filters[fld].value.hasOwnProperty(index)) {
                const value: any = loadEvent.filters[fld].value[index];
                filter.value.push(value);
              }
            }
          } else {
            filter.value.push(loadEvent.filters[fld].value);
          }

          filterReq.filters.push(filter);
        }
      }
    }

    this.getData(pagingReq, filterReq);
  }

  convertOffsetToPage(offset: number) {
    if (offset === 0) {
      return 1;
    } else {
      return Math.floor(offset / this.pageSize + 1);
    }
  }

  convertPageToOffset(page: number) {
    return (page - 1) * this.pageSize;
  }

  getData(pageReq: PagingRequest, filterReq: FilterRequest) {
    //this.blockUIService.startBlockUI('Processing');

    this.dataService
      .getAll(pageReq, filterReq, false)
      .pipe(
        map((responseData: any) => {
          this.listData = responseData.result;
          this.totalRecords = responseData.totalRecords;
          this.pageOffset = this.convertPageToOffset(responseData.page);
        }),
        finalize(() => {
         // this.blockUIService.stopBlockUI();
        })
      )
      .subscribe(null, null, () => {
        this.loadCompleted = true;
      });
  }

  addNew() { }
  onRowSelect(event) { }
  resetSearch() {
    this.resetPage();
    this.resetSort();
  }
  resetPage() {
    this.pageOffset = 0;
    this.page = 1;
  }
  resetSort() {
    this.mytable._sortField = 'name';
    this.mytable._sortOrder = 1;
    this.mytable.sortSingle();
  }
}
