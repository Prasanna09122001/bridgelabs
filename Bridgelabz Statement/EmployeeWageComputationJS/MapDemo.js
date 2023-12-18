let keystring="a string";
let keyobj={};
let keyFunc=function(){};

let myMap=new Map();
myMap.set(keystring,"Value Associated with 'a string'");
myMap.set(keyobj,"value Associated with keyObj");
myMap.set(keyFunc,"Value Associated with KeyFunc");

//geeting the values
let size = myMap.size;
console.log(size);
let valStr = myMap.get(keystring);
console.log(valStr);
let isKeyExist=myMap.has("a string");
console.log(isKeyExist);

//loop
for(let[key,value] of myMap)
console.log("Loop1:"+key+"="+value);

for(let[key,value] of myMap.entries())
console.log("Loop2:"+key+"="+value);

for(let key in myMap.keys)
console.log("Loop3"+key);

for(let value in myMap.values)
console.log("Loop4"+value);

let first = new Map([[1,'One'],[2,'Two'],[3,'Three']]);
let second = new Map([[1,'a'],[2,'b']]);
let merged = new Map([...first,...second,[3,'c']]);
console.log(merged);

let haskey = merged.has(1);
console.log(haskey)

let delkey = merged.delete(1);
console.log(delkey);

console.log(merged.size);

console.log(merged);