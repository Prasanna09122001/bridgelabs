const array1=[12,123,1234,1223455];
const array2=[1,2,3,4,5];
array1.push(123456);
console.log(array1);

console.log(array1.indexOf(123));
console.log(array1.length);
console.log(array1[4]);

const array3=array2.map(Element=>Element*2);
console.log(array3);

const filteredArray=array2.filter(Element=>Element>2);
console.log(filteredArray);

const sortedDesc = array2.sort((a,b)=>a>b ? -1:1);
console.log(sortedDesc);

const sortedAsce = array2.sort((a,b)=>a<b ? -1:1);
console.log(sortedAsce);

array2.forEach(Element=>
    (
        console.log(Element)
    ));

const numarray =[6,7,8,9,10];
const newarray=array2.concat(numarray);
console.log(newarray);

const EveryMethod= numarray.every(element=> element>3);
console.log(EveryMethod);

const Summethod = numarray.some(element=>element>9);
console.log(Summethod);

const includearray = array2.includes(5);
console.log(includearray);

const StrArray = ["P","R","A","S","A","N","N","A"];
const jointArray = StrArray.join('');
console.log(jointArray); 

const Array2 = [1,2,5,4,8];
const reducedArray=Array2.reduce((total,current)=> total+current);
console.log(reducedArray);  

const FindArray= Array2.find(element => element<3);
console.log(FindArray);

const findIndex= Array2.findIndex(element=>element==4);
console.log(findIndex);

const sliceArray=StrArray.slice(3,6);
console.log(sliceArray);

const reverseArray = Array2.reverse();
console.log(reverseArray);

var fillarray=new Array(3);
console.log(fillarray);

const filledArray = fillarray.fill(10);
console.log(filledArray);

const popvalue=Array2.pop();
console.log(Array2);

const shiftarray= Array2.shift();
console.log(shiftarray);

const Stringarray = ["P","A","S","A"];
const unshiftarray= Stringarray.unshift("PA");
console.log(Stringarray+" "+unshiftarray);

// 08/09/2023
let dogs=["Bulldog","Beagle","Labrador"];
let cats=["Americal curl","Bengal"];
let birds=["Falcons","Ducks","Flamingoes"];

//Array Copy Elemnents
let slicedogs = dogs.slice(1,2);       // first element is start and second element is end
console.log(slicedogs);
let copyDogs =[...dogs];               // copy the elements from one array to other
console.log(copyDogs);
let Dogs = dogs.slice(0);              // The element is Starting number
console.log(Dogs);

//stack
let pushdog=dogs.push("Golden Retreiver");   //Addd the Last element in the Array  
console.log(pushdog);
let popDog=dogs.pop();                       // Remove the last element in the array
console.log(popDog);
Dogs[Dogs.length]="Poodle";                  // Add the element in the last
console.log(Dogs);

//Add and Remove from the first
let addfirst = Dogs.unshift("Golden Retreiver");
let removefirst = Dogs.shift();

//Automatic Add and Remove Elements
Dogs.splice(2,1,"pug","Boxer");
console.log(Dogs);

//Concat
let animals= Dogs.concat(cats,birds);
console.log(animals)
let newanimals=[...Dogs,...cats,...birds].toString();
let sortdogs= Dogs.sort();
console.log(sortdogs);
function scanArray([f,s]){
    console.log(f+" "+s);
}
scanArray(cats);

let allanimals="";
for(let animal in animals)
{
    allanimals+=animal;
}
console.log(allanimals);
