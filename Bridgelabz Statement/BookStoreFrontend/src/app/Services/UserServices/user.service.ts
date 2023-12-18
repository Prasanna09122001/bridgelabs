import { Injectable } from '@angular/core';
import { HttpService } from '../HttpServices/http.service';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private httpService: HttpService) { }

  loginservice(reqData: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token'
      }),
    };
    return this.httpService.postService('User/Login', reqData, false, httpAuthOptions);
  };

  ForgotPassword(reqData: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token',
      }),
    };
    return this.httpService.postService(
      'User/ForgetPassword?email=' + reqData.email,
      {},
      false,
      httpAuthOptions
    );
  }
  Register(reqData: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token',
      }),
    };
    return this.httpService.postService(
      'User/Register',
      reqData,
      false,
      httpAuthOptions
    );
  }

  Resetpassword(auth: any, reqData: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + auth,
      }),
    };
    return this.httpService.updateService(
      'User/ResetPassword',
      reqData,
      true,
      httpAuthOptions
    );
  }
  GetBooks() {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token',
      }),
    };
    return this.httpService.getservices(
      'Book/GetAllBooks',
      true,
      httpAuthOptions
    );
  }
  GetById(bookid: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token',
      }),
    };
    return this.httpService.getservices(
      'Book/GetBooksById?bookid=' + bookid,
      true,
      httpAuthOptions
    );
  }
  AddFeedback(reqData: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.postService(
      'Feedback/AddFeedback',
      reqData,
      true,
      httpAuthOptions
    );
  }
  GetFeedack(bookid: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token',
      }),
    };
    return this.httpService.getservices(
      'Feedback/GetFeedback?bookid=' + bookid,
      true,
      httpAuthOptions
    );
  }
  GetAllWishist() {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.getservices(
      'WishList/GatAllBooksinWishList',
      true,
      httpAuthOptions
    );
  }
  GetAllCart() {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.getservices(
      'Cart/GatAllBooksinCart',
      true,
      httpAuthOptions
    );
  }
  RemoveBookFromWishlist(bookid: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.deleteService(
      'WishList/RemoveBookToWishList?bookid=' + bookid,
      true,
      httpAuthOptions
    );
  }
  MoveBookToCart(bookid: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.updateService(
      'WishList/AddBooksFromWishlistFromCart?bookid='+bookid,
      {},
      true,
      httpAuthOptions
    );
  }
  AddBookToWishlist(reqdata: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.postService(
      'WishList/AddBookToWishList',
      reqdata,
      true,
      httpAuthOptions
    );
  }
  RemoveBookFromCart(bookid: any) {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.deleteService(
      'Cart/RemoveBookFromCart?bookid=' + bookid,
      true,
      httpAuthOptions
    );
  }
  GetAllPersonalDetails() {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.getservices(
      'Personal/GetAllPersonalDetails',
      true,
      httpAuthOptions
    );
  }
  AddBookTocart(reqData: any){
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.postService(
      'Cart/AddBookToCart',
      reqData,
      true,
      httpAuthOptions
    );
  }
  AddPersonalDetails(reqData: any){
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.postService(
      'Personal/AddPersonalDetails',
      reqData,
      true,
      httpAuthOptions
    );
  }
  UpdatePersonalDetails(reqData: any){
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.updateService(
      'Personal/UpdatePersonalDetails',
      reqData,
      true,
      httpAuthOptions
    );
  }
  Orderdetails(reqData: any){
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.postService(
      'Order/AddOrderDetails',
      reqData,
      true,
      httpAuthOptions
    );
  }
  updatecount(reqData: any){
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token'),
      }),
    };
    return this.httpService.updateService(
      'Cart/UpdateBooksinCart',
      reqData,
      true,
      httpAuthOptions
    );
  }GetAllOrderDetails() {
    let httpAuthOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: 'Bearer ' + localStorage.getItem('Token')
      }),
    };
    return this.httpService.getservices(
      'SummaryDetails/GetAllSummaryDetails',
      true,
      httpAuthOptions
    );
  }

}
