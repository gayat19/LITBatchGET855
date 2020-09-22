import {HttpClient} from '@angular/common/http';
import {Injectable} from '@angular/core';
import {Region} from '../models/region';

@Injectable()
export class RegionService{
    constructor(private http:HttpClient,private http1:HttpClient,private http2:HttpClient,private http3:HttpClient){
    }

    getAllRegionsFromAPI(){
        return this.http
        .get("http://localhost:54578/api/Regions");
    }

    insertRegionThroughAPI(region:Region){
        return this.http1.post("http://localhost:54578/api/Regions",region);
    }

    updateRegioninAPI(region:Region){
        return this.http2.put("http://localhost:54578/api/Regions/"+region.RegionID,region);
    }
    deleteRegionUsingAPI(id:number){
        var url = "http://localhost:54578/api/Regions/"+id;
        return this.http3.delete(url);;
    }
}