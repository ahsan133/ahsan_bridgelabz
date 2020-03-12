import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatDialogModule} from '@angular/material/dialog';
import {MatIconModule} from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, FormGroup, ReactiveFormsModule } from '@angular/forms';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import {GoogleLoginProvider, FacebookLoginProvider, AuthService } from 'angular-6-social-login';
import { SocialLoginModule, AuthServiceConfig } from 'angular-6-social-login'; 
import {MatToolbarModule} from '@angular/material/toolbar'; 
import {MatMenuModule} from '@angular/material/menu';
import {MatDividerModule} from '@angular/material/divider';
import {MatButtonModule, MatCheckboxModule, MatButtonToggleModule, MatExpansionModule, MatRippleModule,MatSidenavModule,
  MatSliderModule,MatSlideToggleModule,} from '@angular/material';
  import { CommonModule } from "@angular/common";
  import { ImageCropperModule } from 'ngx-image-cropper';
  import {MatTooltipModule} from '@angular/material/tooltip';
  import {MatListModule} from '@angular/material/list';
  import {MatGridListModule} from '@angular/material/grid-list';
  import {DragDropModule} from '@angular/cdk/drag-drop';
  import { FlexLayoutModule } from '@angular/flex-layout';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './Component/login/login.component';
import { RegisterComponent } from './Component/register/register.component';
import { ForgotComponent } from './Component/forgot/forgot.component';
import { DashboardComponent } from './Component/dashboard/dashboard.component';
import { ProfilePicture } from './Component/dashboard/dashboard.component';
import { NotesComponent } from './Component/notes/notes.component';
import { CollaboratorComponent } from './Component/collaborator/collaborator.component';
import { CardComponent } from './Component/card/card.component';
import { GetNotesComponent } from './Component/get-notes/get-notes.component';
import { AllNotesComponent } from './Component/all-notes/all-notes.component';
import { IconsComponent } from './Component/icons/icons.component';
import { GetNoteCollaboratorComponent } from './Component/get-note-collaborator/get-note-collaborator.component';
import { RemainderComponent } from './Component/remainder/remainder.component';
import { ArchiveComponent } from './Component/archive/archive.component';
import { TrashComponent } from './Component/trash/trash.component';
import { ImageUploadComponent } from './Component/image-upload/image-upload.component';
import { LabelsComponent } from './Component/labels/labels.component';
import { AddLabelComponent } from './Component/add-label/add-label.component';
import { EditLabelComponent } from './Component/edit-label/edit-label.component';
import { AdminDashboardComponent} from './Component/admin-dashboard/admin-dashboard.component';
import {AdminRegisterComponent} from './Component/admin-register/admin-register.component';

export function socialConfigs() {  
  const config = new AuthServiceConfig(  
    [  
      {  
        id: FacebookLoginProvider.PROVIDER_ID,  
        provider: new FacebookLoginProvider('2793897927336795')  
      },  
      {  
        id: GoogleLoginProvider.PROVIDER_ID,  
        provider: new GoogleLoginProvider('951724777642-fro4lf3fuibjkfb9nvk95iitva7pvk65.apps.googleusercontent.com')  
      }  
    ]  
  );  
  return config;  
  }

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ForgotComponent,
    DashboardComponent,
    ProfilePicture,
    NotesComponent,
    CollaboratorComponent,
    CardComponent,
    GetNotesComponent,
    AllNotesComponent,
    IconsComponent,
    GetNoteCollaboratorComponent,
    RemainderComponent,
    ArchiveComponent,
    TrashComponent,
    ImageUploadComponent,
    LabelsComponent,
    AddLabelComponent,
    EditLabelComponent,
    AdminDashboardComponent,
    AdminRegisterComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatFormFieldModule,
    MatDialogModule,
    MatIconModule,
    MatCardModule,
    MatInputModule,
    BrowserAnimationsModule,
    HttpClientModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    MatSnackBarModule,
    SocialLoginModule,
    MatSidenavModule,
    MatToolbarModule,
    MatMenuModule,
    MatDividerModule,
    MatButtonToggleModule,
    MatButtonModule,
    MatCheckboxModule,
    MatExpansionModule,
    MatRippleModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    CommonModule,
    ImageCropperModule,
    MatTooltipModule,
    MatListModule,
    MatGridListModule,
    DragDropModule,
    FlexLayoutModule

  ],
  entryComponents: [
    EditLabelComponent,
    AddLabelComponent,
    ProfilePicture, 
    CollaboratorComponent,
    CardComponent,
    ImageUploadComponent],

  providers: [
    AuthService, 
    {  
      provide: AuthServiceConfig,  
      useFactory: socialConfigs  
    }  
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
export class MyModule { }
