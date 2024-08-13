//arrow function syntax
// const fn=(args)=>expression
const Greet = (name) => "Hello " + name;
console.log(Greet("Sachin"));
console.log(Greet("Virat"));
const Add = (a, b) => a + b;
console.log(Add(34, 45));
let IsEven = (n) => n % 2 == 0;
console.log(IsEven(2) ? "Even" : "Odd");
console.log(IsEven(21) ? "Even" : "Odd");
//array function with multiple expressions
const Sum = (a) => {
  let result = 0;
  for (let k of a) result = result + k;
  return result;
};
console.log(Sum([12, 23, 34, 45, 55, 67]));
