import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SelectmovieComponent } from './selectmovie.component';

describe('SelectmovieComponent', () => {
  let component: SelectmovieComponent;
  let fixture: ComponentFixture<SelectmovieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SelectmovieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SelectmovieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
