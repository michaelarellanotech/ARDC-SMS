import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SMSPOCService {
  constructor(private httpClient: HttpClient) {}

  get(): Observable<any> {
    return this.httpClient.get(
      `http://localhost:26355/api/CompetitorEntryDataService/SMSPOCList`
    );
  }

  sendSMS(data): Observable<any> {
    return this.httpClient.post(`http://localhost:26355/api/CompetitorEntryDataService/SMSSend`, data);
  }
}
