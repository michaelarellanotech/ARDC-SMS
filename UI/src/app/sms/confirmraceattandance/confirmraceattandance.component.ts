import { Component, OnInit } from '@angular/core';
import { SMSPOCService } from '../confirmraceattandance.service';

@Component({
  selector: 'app-confirmraceattandance',
  templateUrl: './confirmraceattandance.component.html',
  styleUrls: ['./confirmraceattandance.component.css']
})
export class ConfirmRaceAttandanceComponent implements OnInit {
  testData: any[];
  selectedValues = [];
  sendSMSVisible = false;

  constructor(
    private smsPOCService: SMSPOCService) { }

  ngOnInit() {
    this.loadData();
  }

  loadData() {
    this.smsPOCService.get().subscribe(data => {
      this.testData = data;
    });
  }

}
