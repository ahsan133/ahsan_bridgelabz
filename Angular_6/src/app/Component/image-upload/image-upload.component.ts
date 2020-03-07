import { Component, OnInit, Inject } from '@angular/core';
import { ImageCroppedEvent, base64ToFile } from 'ngx-image-cropper';
import { MatSnackBar, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { NotesService } from 'src/app/Services/notes.service';

@Component({
  selector: 'app-image-upload',
  templateUrl: './image-upload.component.html',
  styleUrls: ['./image-upload.component.scss']
})
export class ImageUploadComponent implements OnInit {

  fileToUpload: File;
  filename;
  imageChangedEvent: any = '';
  croppedImage: any = '';
  
  constructor(
    private notes:NotesService,
    public snackbar: MatSnackBar,
    public dialogRef: MatDialogRef<ImageUploadComponent>,
    @Inject(MAT_DIALOG_DATA) public onenote: any) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.dialogRef.close();
}

  fileChangeEvent(event: any): void {
    this.filename = event.target.files[0].name;
    console.log(this.filename + " name");
    
    this.imageChangedEvent = event;
  }
imageCropped(event: ImageCroppedEvent) {
  this.croppedImage = base64ToFile(event.base64);
  this.fileToUpload = new File([this.croppedImage], this.filename);
}


  addImage(){
    this.notes.addImage(this.onenote.id ,this.fileToUpload).subscribe((status :any) => {
      if(status != null)
      {
        this.dialogRef.close();
        this.snackbar.open('Image added','', {duration: 2000});
      }
  });
}
}
