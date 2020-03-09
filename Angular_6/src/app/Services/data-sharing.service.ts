import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {

  private messageSource = new BehaviorSubject(false);
  currentMessage = this.messageSource.asObservable();

  private card = new BehaviorSubject(false);
  currentCard = this.card.asObservable();

  constructor() { }

  changeMessage(message: boolean) {
    this.messageSource.next(message)
  }

  changeCard(value: boolean){
    this.card.next(value)
  }
}
