import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildingLocatorComponent } from './building-locator.component';

describe('BuildingLocatorComponent', () => {
  let component: BuildingLocatorComponent;
  let fixture: ComponentFixture<BuildingLocatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BuildingLocatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildingLocatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
