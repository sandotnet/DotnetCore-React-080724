let no = [12, 33, 45, 56, 67, 78, 89, 90];
no.forEach((i) => console.log(i));
no.forEach((i) => console.log(i * i));
no.forEach((i) => {
  if (i % 2 == 0) console.log(i);
});
console.clear();
//find() returns 1st value in the sequence
let k = no.find((i) => i > 50);
console.log(k);
k = no.find((i) => i % 2 != 0);
console.log(k);
//filter() used to filter the array retrun array as output
let a = no.filter((i) => i % 2 == 0);
console.log(a);
a = no.filter((i) => i > 80);
console.log(a);
