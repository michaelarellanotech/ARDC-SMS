import { Component, OnInit, ViewChild, Injector } from '@angular/core';
import { ListPageBase } from 'src/app/common/listpage';
import { Router } from '@angular/router';
import { Table } from 'primeng';
import { OfficialService } from './officials.service';

@Component({
  selector: 'app-officials',
  templateUrl: './officials.component.html',
  styleUrls: ['./officials.component.scss']
})
export class OfficialsComponent extends ListPageBase implements OnInit {
  nameTextSearch: string;
  
  @ViewChild('table') public mytable: Table;

  constructor(
    public injector: Injector,
    private router: Router,
    private userService: OfficialService
  ) {
    super(injector);
    this.dataService = this.userService;
  }

  ngOnInit() {
  }

  addNew() {
    this.router.navigate(['/surveys/surveyedit/details']);
  }

  onRowSelect($event) {
    this.router.navigate([`surveys/surveyedit/${$event.data.id}/details`]);
  }
}
