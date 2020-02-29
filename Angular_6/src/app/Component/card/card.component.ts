import { Component, OnInit } from '@angular/core';
import {MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<CardComponent>) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.dialogRef.close();
}

}
