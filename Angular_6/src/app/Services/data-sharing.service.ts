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

  private labelSource = new BehaviorSubject(false);
  currentLabel = this.labelSource.asObservable();

  private valueSource = new BehaviorSubject(null);
  currentValue = this.valueSource.asObservable();

  private dataSource = new BehaviorSubject(null);
  currentData = this.dataSource.asObservable();

  constructor() { }

  changeMessage(message: boolean) {
    this.messageSource.next(message)
  }

  changeCard(value: boolean){
    this.card.next(value)
  }

  changeLabel(value: boolean){
    this.labelSource.next(value)
  }

  changeValue(value: string) {
    this.valueSource.next(value)
  }

  changeData(value: any){
    this.dataSource.next(value)
  }
}
