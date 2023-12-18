import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from 'src/app/Services/DataServices/data.service';
import { UserService } from 'src/app/Services/UserServices/user.service';

@Component({
  selector: 'app-wishlist',
  templateUrl: './wishlist.component.html',
  styleUrls: ['./wishlist.component.scss']
})
export class WishlistComponent {
  wishlist: any
  wishlistarray?: any=[];
  constructor(private userservice:UserService, private router: Router,private dataservice:DataService){}

  ngOnInit(): void{
      this.wishlistbooks();
  }
  wishlistbooks(){
    this.userservice.GetAllWishist().subscribe((response)=>{
      console.log(response)
      this.wishlist=response;
      this.wishlistarray=this.wishlist.data;
      console.log(this.wishlist.data);
      this.dataservice.updateWishlistItems(this.wishlistarray.length);
    },
    (error)=>{
        this.router.navigate(['dashboard/requestpage'])
    });
  }
  Remove(bookid: any): void{
    this.userservice.RemoveBookFromWishlist(bookid).subscribe((Response)=>{
      console.log(Response);
     this.wishlistbooks();
    })
  }
  MoveToCart(bookid: any){
    this.userservice.MoveBookToCart(bookid).subscribe((response)=>{
      console.log(Response);
      this.wishlistbooks();
      this.router.navigate(['dashboard/cart']);
    })
  }
}
