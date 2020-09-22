import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewRegionsComponent } from './view-regions/view-regions.component';
import {RegionService} from './services/RegionService';
import { AddRegionComponent } from './add-region/add-region.component';
import { UpdateRegionComponent } from './update-region/update-region.component';
import { DeleteRegionComponent } from './delete-region/delete-region.component';


@NgModule({
  declarations: [
    AppComponent,
    ViewRegionsComponent,
    AddRegionComponent,
    UpdateRegionComponent,
    DeleteRegionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [RegionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
