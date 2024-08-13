let students = [
  { Id: 343, Name: "Rohan", Age: 12 },
  { Id: 789, Name: "Kalpesh", Age: 11 },
  { Id: 231, Name: "Manoj", Age: 10 },
  { Id: 890, Name: "Ayush", Age: 10 },
  { Id: 232, Name: "Jaya", Age: 11 },
  { Id: 889, Name: "Binu", Age: 12 },
];
//retrun object from the function
function GetStudentById(id) {
  for (let ob of students) {
    if (ob.Id == id) return ob;
  }
  return null;
}
let obj = GetStudentById(349);
if (obj != null) {
  console.log(`ID:${obj.Id} Name:${obj.Name} Age:${obj.Age}`);
} else console.log("Invalid Id");
//return array
function GetCities() {
  return ["Pune", "Chennai", "Mumbai", "Hyderabad"];
}
for (let city of GetCities()) {
  console.log(city);
}
//return array of objects
function GetStudents() {
  return students;
}
for (let ob of GetStudents()) {
  console.log(`ID:${ob.Id} Name:${ob.Name} Age:${ob.Age}`);
}
