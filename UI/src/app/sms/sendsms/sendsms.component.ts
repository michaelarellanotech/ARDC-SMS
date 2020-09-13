import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { SMSPOCService } from '../confirmraceattandance.service';

@Component({
  selector: 'app-sendsms',
  templateUrl: './sendsms.component.html',
  styleUrls: ['./sendsms.component.scss']
})
export class SendSMSComponent implements OnInit {
  constructor(
    private smsPOCService: SMSPOCService) { }

  @Input() visible: boolean;
  @Input() recipients: any[];
  @Output() closeAction = new EventEmitter();

  ngOnInit() {
  }

  onShow() { }
  onHide() {
    this.closeAction.emit();
  }

  sendSMS() {
    this.smsPOCService.sendSMS(this.recipients).subscribe(x => {});
    this.onHide();
  }
}
