import { Component, OnInit } from '@angular/core';
import { Region } from '../models/region';
import { RegionService } from '../services/RegionService';

@Component({
  selector: 'app-add-region',
  templateUrl: './add-region.component.html',
  styleUrls: ['./add-region.component.css']
})
export class AddRegionComponent implements OnInit {

  region:Region;
  message;
  constructor(private regionService:RegionService) { 
    this.region = new Region();
  }
  addRegion(){
    this.regionService.insertRegionThroughAPI(this.region).subscribe((data)=>{
      this.message=data;
    })
  }
  ngOnInit(): void {
  }

}
