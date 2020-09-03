import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExplainEventsComponent } from './explain-events.component';

describe('ExplainEventsComponent', () => {
  let component: ExplainEventsComponent;
  let fixture: ComponentFixture<ExplainEventsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExplainEventsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExplainEventsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
