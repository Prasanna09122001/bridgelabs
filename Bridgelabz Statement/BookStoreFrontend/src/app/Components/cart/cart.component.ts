import { Component, ElementRef, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatExpansionPanel } from '@angular/material/expansion';
import { Router } from '@angular/router';
import { DataService } from 'src/app/Services/DataServices/data.service';
import { UserService } from 'src/app/Services/UserServices/user.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent {
  @ViewChild('fullnameInput') fullnameInput!: ElementRef;
  @ViewChild('mobile') mobile!: ElementRef;
  @ViewChild('address') address!: ElementRef;
  @ViewChild('city') city!: ElementRef;
  @ViewChild('state') state!: ElementRef;
  @ViewChild('homeRadio') homeRadio!: ElementRef<HTMLInputElement>;
  @ViewChild('workRadio') workRadio!: ElementRef<HTMLInputElement>;
  @ViewChild('othersRadio') othersRadio!: ElementRef<HTMLInputElement>;

  panelOpenState = false;
  numberOfBooks: number = 1;
  selectedGender: string | undefined;
  currentUrl: string;
  customerId: any;
  customer: any

  cartlist: any
  cartlistarray?: any = []
  personal: any
  personalarray?: any = []
  showOtherDetails: boolean = false;
  selectedBook: any = {
    fullname: 'Prasanna Venkatesh R P',
    mobilenum: '6369988552'
  };

  constructor(private userservice: UserService, private router: Router,private dataService:DataService) {
    this.currentUrl = this.router.url;
  }


  ngOnInit(): void {
  // location.reload();
    this.getallcarts();
    this.getpersonaldetails();
    
  }
  getallcarts()
  {
    this.userservice.GetAllCart().subscribe((response) => {
      console.log(response)
      this.cartlist = response;
      this.cartlistarray = this.cartlist.data;
      console.log(this.cartlist.data);
      this.dataService.updateCartItems(this.cartlistarray.length)
    });
  }
  getpersonaldetails(){
    this.userservice.GetAllPersonalDetails().subscribe((response) => {
      console.log(response);
      this.personal = response;
      this.personalarray = this.personal.data;
      console.log(this.personal.data)
    });
  }
  remove(bookid: any) {
    this.userservice.RemoveBookFromCart(bookid).subscribe((response) => {
      console.log(response);
      this.getallcarts();
       });
  }
  openCustomerPanel(panel: MatExpansionPanel) {
    panel.open();
  }
  openOrderPanel(panel: MatExpansionPanel) {
    panel.open();
  }
  isEditMode: { [key: string]: boolean } = {};

  toggleEditMode(customerid: any) {
    this.isEditMode[customerid] = !this.isEditMode[customerid];
  }


  selectedItem: string | null = null;

  toggleOtherDetailsVisibility(customerId: string, fullname: string, mobilenum: string) {
    localStorage.setItem('customerid', customerId);
    if (this.selectedItem === customerId) {
      this.selectedItem = customerId;
      this.selectedBook = null;
    } else {
      this.selectedItem = customerId;
      this.selectedBook = { fullname, mobilenum };
    }
  }
  type(): string {
    let selectedValue = '';
    if (this.homeRadio.nativeElement.checked) {
      selectedValue = this.homeRadio.nativeElement.value;
      return selectedValue
    } else if (this.workRadio.nativeElement.checked) {
      selectedValue = this.workRadio.nativeElement.value;
      return selectedValue
    } else if (this.othersRadio.nativeElement.checked) {
      selectedValue = this.othersRadio.nativeElement.value;
      return selectedValue
    } return selectedValue
  }
  onSave(id: any) {
    let reqData = {
      fullname: this.fullnameInput.nativeElement.value,
      mobilenum: this.mobile.nativeElement.value,
      address: this.address.nativeElement.value,
      state: this.state.nativeElement.value,
      city: this.city.nativeElement.value,
      typeId: id
      // Retrieve values of other input fields in a similar manner
    }
    console.log(reqData);
    this.userservice.UpdatePersonalDetails(reqData).subscribe((response) => {
      console.log(response)
    })
  }
  Oncheckout() {
    this.customer=localStorage.getItem('customerid');
    let reqData = {
         customerid: +this.customer
    }
    this.userservice.Orderdetails(reqData).subscribe((response)=>{
      console.log(response);
      this.getallcarts();
      this.router.navigate(['dashboard/summary'])
    })
  }
  increment(book: any,count: number) {
    let bookcount = count+1;
    let reqData = {
      bookid: book,
      bookCountOrder: bookcount
    }
    console.log(bookcount,book);
    this.userservice.updatecount(reqData).subscribe((response)=>{
      console.log(response);
    })
    location.reload()
  }

  decrement(book: any,count: any) {
    let bookcount = count;
    if (count > 1) {
      count-1;
      bookcount = count-1
    }
    let reqData = {
      bookid: book,
      bookCountOrder: bookcount
    }
    this.userservice.updatecount(reqData).subscribe((response)=>{
      console.log(response);
    })
    location.reload();
  }
}
