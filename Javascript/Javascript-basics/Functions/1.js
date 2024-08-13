//function defination
// function fun_name(args)
// {
//     //statements
// }
function Message() {
  console.log("Hello World!!!");
}
//invoke function
Message();
function Greet(name) {
  console.log("Hello " + name);
}
Greet("Sachin");
Greet("Rahul");
function Add(a, b) {
  let result = a + b; //local variable
  console.log("Result: " + result);
}
Add(3, 5);
function Note(name, msg = "Hello") {
  //default value to the params
  console.log(`${msg},${name}`);
}
Note("Sachin");
Note("Rahul", "Good Evening");
function IsEven(no) {
  if (no % 2 == 0) console.log(`${no} is Even`);
  else console.log(`${no} is Even`);
}
IsEven(10);
IsEven(21);
IsEven(); //taken no value as undefind
