import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private messageSource = new BehaviorSubject('');
  receiveData = this.messageSource.asObservable();
 
  constructor() { }

  SendData(message: string) {
    console.log(message)
    this.messageSource.next(message)
  }
  
  private cartItems = new BehaviorSubject<number>(0);
  private wishlistItems = new BehaviorSubject<number>(0);

  getCartItems() {
    return this.cartItems.asObservable();
  }

  getWishlistItems() {
    return this.wishlistItems.asObservable();
  }

  updateCartItems(count: number) {

    this.cartItems.next(count);
  }

  updateWishlistItems(count: number) {
    this.wishlistItems.next(count);
  }

}
