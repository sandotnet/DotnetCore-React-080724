//simple if
let uname = "Sachin";
if (uname == "Sachin") {
  console.log("Good Morning");
}
//if-else
let k = 10;
if (k % 2 == 0) console.log(`${k} is Even`);
else console.log(`${k} is Odd`);
//nested-if
let a = 10;
let b = 30;
let c = 20;
//find max of 3 nos
if (a > b) {
  if (a > c) console.log(`${a} is Max`);
  else console.log(`${c} is Max`);
} else {
  if (b > c) {
    console.log(`${b} is Max`);
  } else console.log(`${c} is Max`);
}
