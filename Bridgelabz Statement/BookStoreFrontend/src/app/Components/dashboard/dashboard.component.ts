import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { count } from 'rxjs';
import { DataService } from 'src/app/Services/DataServices/data.service';
import { UserService } from 'src/app/Services/UserServices/user.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  cartCount=0;
  wishlistcount=0;
  cartlist: any
  cartlistarray?: any = []
  wishlist: any
  wishlistarray?: any = []
  constructor(private dataservice: DataService, private router: Router, private userservice: UserService) { }

  SearchNotes(event: any) {
    console.log(event.target.value);
    this.dataservice.SendData(event.target.value)
  }
  clearLocalStorage() {
    localStorage.clear();
    this.router.navigate(['home/Log']);
  }
  ngOnInit() {
    this.dataservice.getCartItems().subscribe(count=>{
      this.cartCount = count;
      console.log('dashboard'+this.cartCount);
    });
    this.dataservice.getWishlistItems().subscribe(count=>{
      this.wishlistcount = count;
      console.log(this.wishlistcount);
    });
      this.userservice.GetAllCart().subscribe((response) => {
      console.log(response)
      this.cartlist = response;
      this.cartlistarray = this.cartlist.data;
      this.dataservice.updateCartItems(this.cartlistarray.length);
    });
    this.userservice.GetAllWishist().subscribe((response) => {
      console.log(response)
      this.wishlist = response;
      this.wishlistarray = this.wishlist.data;
      this.dataservice.updateWishlistItems(this.wishlistarray.length); 
    });
  }
}
