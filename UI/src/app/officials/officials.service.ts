
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PagingRequest, FilterRequest } from '../common/paging/PagedResult.model';
import { OfficialsPagedList } from './officials.model';
import { environment } from 'src/environments/environment';
import { ServiceBase } from '../common/servicebase';

@Injectable({
  providedIn: 'root'
})
export class OfficialService extends ServiceBase {
  apiURL: string = environment.apiURL;

  constructor(private httpClient: HttpClient) {
    super();
  }

  getAll(
    pageReq: PagingRequest,
    filterReq: FilterRequest
  ): Observable<OfficialsPagedList> {
    const q1 = this.serialize(pageReq, '');
    const q2 = this.serialize(filterReq, '');

    return this.httpClient.get<OfficialsPagedList>(
      `${this.apiURL}/officials?${q1}&${q2}`
    );
  }

}
