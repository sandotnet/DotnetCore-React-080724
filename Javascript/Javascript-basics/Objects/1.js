//working with data class and its methods
let obj = new Date();
console.log(obj); //current system date & time
console.log(obj.toLocaleString()); //retrun local date and time
console.log(obj.toLocaleDateString()); //return only date
//customize the date
let obj1 = new Date(2010, 10, 12); //yy,mm,dd
console.log(obj1.toLocaleDateString());
let obj2 = new Date(2022, 2, 21);
console.log(obj2.getFullYear()); //2022
console.log(obj2.getMonth());
console.log(obj2.getDate());
console.log(obj2.getDay()); //returns day of the week
console.log(obj.getTime());
console.log(obj.getHours());
console.log(obj.getMinutes());
console.log(obj.getSeconds());
