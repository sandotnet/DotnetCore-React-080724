function Greet(name) {
  let msg = "Hello " + name;
  return msg; //returning string
}
function Sqaure(no) {
  let result = no * no;
  return result; //returning number
}
function IsEven(no) {
  let result;
  if (no % 2 == 0) result = true;
  else result = false;
  return result; //retruning bool
}
//here a is array type
function Sum(a) {
  let sum = 0;
  for (let k of a) {
    sum = sum + k;
  }
  return sum;
}
let result = Greet("Sachin");
console.log(result);
result = Sqaure(12);
console.log(result);
result = IsEven(12);
console.log(result ? "Even" : "Odd");
result = Sum([12, 23, 34, 45, 55, 67]);
console.log("Sum or Array no: " + result);
