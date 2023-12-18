var val;
let datatype1 = typeof val;
console.log(datatype1);

var val1=0;
let datatype2 = typeof val1;
console.log(datatype2);

var val3=10n;
let datatype3 = typeof val3;
console.log(datatype3);

var val4="foo";
let datatype4 = typeof val4;
console.log(datatype4);

var val5=true;
let datatype5 = typeof val5;
console.log(datatype5);

let datatype6=typeof Symbol("id");
console.log(datatype6);

let datatype7= typeof Math
console.log(datatype7);

let datatype8=typeof null
console.log(datatype8);

let hello=function()
{
    console.log("hello");
}

let datatype9 = typeof hello;
console.log(datatype9);

let datatype10 = typeof(NaN);
console.log(datatype10);