import { Component, OnInit, OnChanges, SimpleChanges, DoCheck, Input } from '@angular/core';

@Component({
  selector: 'app-explain-events',
  templateUrl: './explain-events.component.html',
  styleUrls: ['./explain-events.component.css']
})
export class ExplainEventsComponent implements OnInit,OnChanges,DoCheck {
  @Input()msg:string;
  constructor() {
    console.log("From constructor ");
    this.msg = "Hello";
   }
  ngDoCheck(): void {
    console.log("From the do check "+this.msg);
  }
  ngOnChanges(changes: SimpleChanges): void {
    console.log("From on change ");
  }

  ngOnInit(): void {
    console.log(" The Init ")
  }

}
