import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewRegionsComponent } from './view-regions.component';

describe('ViewRegionsComponent', () => {
  let component: ViewRegionsComponent;
  let fixture: ComponentFixture<ViewRegionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewRegionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewRegionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
