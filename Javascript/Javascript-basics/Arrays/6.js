//map() creates a new array from calling a fn for every array element
//array.map(fn())
const numbers = [4, 9, 16, 25];
let newArr = numbers.map(Math.sqrt);
console.log(newArr);
newArr = numbers.map((n) => n * 10);
console.log(newArr);
newArr = numbers.map((n) => n % 2 == 0);
console.log(newArr);
const persons = [
  { fname: "sachin", lname: "tendulkar" },
  { fname: "virat", lname: "kohli" },
  { fname: "rohith", lname: "sharma" },
];
let result = persons.map((item) => 
[item.fname, item.lname].join(" "));
console.log(result);
let flowers = ["rose", "lilly", "jasmine"];
let r = flowers.map((f) => {
  let m = f[0].toUpperCase() + f.slice(1, f.length);
  return m;
});
console.log(r);
