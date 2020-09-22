import { Component, OnInit } from '@angular/core';
import { Region } from '../models/region';
import { RegionService } from '../services/RegionService';

@Component({
  selector: 'app-delete-region',
  templateUrl: './delete-region.component.html',
  styleUrls: ['./delete-region.component.css']
})
export class DeleteRegionComponent implements OnInit {

  regionId:number;
  regions;
  messgae;
  constructor(private regionService:RegionService) {
    this.regionService.getAllRegionsFromAPI().subscribe((data)=>{
      this.regions = data;
    })
   }

  ngOnInit(): void {

  }
  changeID(rid){
    this.regionId = rid.value;
  }
  deleteRegion(){
      this.regionService.deleteRegionUsingAPI(this.regionId).subscribe(data=>
        {
          this.messgae = data;
        });
  }
}
