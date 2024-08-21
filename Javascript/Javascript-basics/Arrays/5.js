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
let students = [
  { Id: 343, Name: "Rohan", Age: 12 },
  { Id: 789, Name: "Kalpesh", Age: 11 },
  { Id: 231, Name: "Manoj", Age: 10 },
  { Id: 890, Name: "Ayush", Age: 10 },
  { Id: 232, Name: "Jaya", Age: 11 },
  { Id: 889, Name: "Binu", Age: 12 },
];
let obj = students.find((s) => s.Id == 343);
console.log(obj);
let list = students.filter((s) => s.Age > 10);
console.log(list);
