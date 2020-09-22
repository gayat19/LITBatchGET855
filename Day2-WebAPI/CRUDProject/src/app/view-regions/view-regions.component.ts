import { Component, OnInit } from '@angular/core';
import { RegionService } from '../services/RegionService';

@Component({
  selector: 'app-view-regions',
  templateUrl: './view-regions.component.html',
  styleUrls: ['./view-regions.component.css']
})
export class ViewRegionsComponent implements OnInit {
regions
  constructor(private regionService:RegionService) { 

  }
getRegions(){
  console.log("Hello");
  this.regionService.getAllRegionsFromAPI()
  .subscribe((data)=>{
    //console.log(data);
    this.regions = data;
  })
}
  ngOnInit(): void {
  }

}
