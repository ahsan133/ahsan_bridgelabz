import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetNoteCollaboratorComponent } from './get-note-collaborator.component';

describe('GetNoteCollaboratorComponent', () => {
  let component: GetNoteCollaboratorComponent;
  let fixture: ComponentFixture<GetNoteCollaboratorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetNoteCollaboratorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetNoteCollaboratorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
