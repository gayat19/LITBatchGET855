import { Component, OnInit } from '@angular/core';
import { Region } from '../models/region';
import { RegionService } from '../services/RegionService';

@Component({
  selector: 'app-update-region',
  templateUrl: './update-region.component.html',
  styleUrls: ['./update-region.component.css']
})
export class UpdateRegionComponent implements OnInit {

  region:Region;
  message:string;
  constructor(private regionService:RegionService) {
    this.region = new  Region();
   }

  ngOnInit(): void {
  }
  updateRegion(){
    this.regionService.updateRegioninAPI(this.region).subscribe(()=>{
      this.message="Done";
    })
  }

}
