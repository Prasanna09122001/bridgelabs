const fs = require('fs');
const data = {name: "john"};
const jsonstring = JSON.stringify(data);
const filepath = "My Space\MySpace\data.json";
fs.writeFileSync(filepath,jsonstring);
console.log("Data has been added to the dataBase");