//object in javascript
let obj = { Id: 343, Name: "Rohan", Age: 12 }; //Javascript object(anonymous object)
console.log(`ID:${obj.Id} Name:${obj.Name} Age:${obj.Age}`);
//Array of Objects
let students = [
  { Id: 343, Name: "Rohan", Age: 12 },
  { Id: 789, Name: "Kalpesh", Age: 11 },
  { Id: 231, Name: "Manoj", Age: 10 },
  { Id: 890, Name: "Ayush", Age: 10 },
  { Id: 232, Name: "Jaya", Age: 11 },
  { Id: 889, Name: "Binu", Age: 12 },
];
//fetch an object from an array
obj = students[2];
console.log(`ID:${obj.Id} Name:${obj.Name} Age:${obj.Age}`);
//fetch all objects from the array
for (let ob of students) {
  console.log(`ID:${ob.Id} Name:${ob.Name} Age:${ob.Age}`);
}
