import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { UserService } from 'src/app/Services/UserServices/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit{
  RegisterForm!: FormGroup;
    submitted = false;
  
  hide: boolean = true;

  toggleVisibility(): void {
    this.hide = !this.hide;
  }
  constructor(private formBuilder:FormBuilder, private router: Router,private userservice:UserService,private _snackbar:MatSnackBar){}
  ngOnInit() {
    console.log("Oninit life cycle gets called");
    this.RegisterForm = this.formBuilder.group({
      Fullname: ['', [Validators.required]],
      Emailid: ['', [Validators.required, Validators.email]],
      number: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.minLength(8)]]
    });
  }
  onSubmit() {
    console.log(this.RegisterForm.value);
    if (this.RegisterForm.valid) {
      let reqData = {
        Fullname: this.RegisterForm.value.Fullname,
        Email: this.RegisterForm.value.Emailid,
        Phonenumber: this.RegisterForm.value.number,
        password: this.RegisterForm.value.password,
        roles:''
      }
      this.userservice.Register(reqData).subscribe((response)=>{
        console.log(response);
        this._snackbar.open('Registered Succesfully', '', {
          duration: 2000
        });
        this.router.navigate(['home/Log']);
      },
      (error)=>{
        this._snackbar.open('Enter the personal details correctly', '', {
          duration: 2000
        });
      });
    }
    else {
      console.log("The Value is Invalid");
      return;
    }
  }

}
