/*let a=10;
let b=20;
let c= a+b;
console.log("Addition is:" +c);

let s1="10";
let s2="20";
let s= s1+s2;
console.log("Addition is:" +s);

let date = new Date();
let today = "Today is "+(date.getDay())+"/"+date.getMonth()+"/"+date.getFullYear();
console.log(today);
let time = "Time is "+date.getHours()+"/"+date.getMinutes()+"/"+date.getSeconds()+"/"+date.getMilliseconds();
console.log(time);

let a = Math.floor(Math.random()*10)%3;
let  b= Math.floor(Math.random()*10)%3;
let c = Math.floor(Math.random()*10)%3;
let d = Math.floor(Math.random()*10)%3;

var i=0;
while(i<10)
{
     let a= Math.floor(Math.random()*10)%3;
     console.log(a);
     i++;
}
console.log(a+""+b+""+""+c+""+d);*/
var name = "Hi";
function init() {
    var name = "Mozilla"; // name is a local variable created by init
    function displayName() {
      // displayName() is the inner function, that forms the closure
      console.log(name); // use variable declared in the parent function
    }
    displayName();
  }
  init();
  console.log(name);

  
  const add = (function a() 
  {
    let counter = 0;
    console.log("Hi Hello");
    return function a() 
    {
        counter += 1; 
        console.log(counter);
        return counter
    }
    
  } ) 
  ();
  
  add();
  add();
  add();