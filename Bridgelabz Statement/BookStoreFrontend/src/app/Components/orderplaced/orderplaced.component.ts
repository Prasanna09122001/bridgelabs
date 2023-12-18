import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/Services/UserServices/user.service';

@Component({
  selector: 'app-orderplaced',
  templateUrl: './orderplaced.component.html',
  styleUrls: ['./orderplaced.component.scss']
})
export class OrderplacedComponent {
  wishlist: any
  wishlistarray?: any=[];
  constructor(private userservice:UserService, private router: Router){}

  ngOnInit(): void{
  this.userservice.GetAllOrderDetails().subscribe((response)=>{
    console.log(response)
    this.wishlist=response;
    this.wishlistarray=this.wishlist.data;
    console.log(this.wishlist.data);
  });
  }
}
