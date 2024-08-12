let students = [
  { Id: 343, Name: "Rohan", Age: 12 },
  { Id: 789, Name: "Kalpesh", Age: 11 },
  { Id: 231, Name: "Manoj", Age: 10 },
  { Id: 890, Name: "Ayush", Age: 10 },
  { Id: 232, Name: "Jaya", Age: 11 },
  { Id: 889, Name: "Binu", Age: 12 },
];
let GetStudents = () => students;
for (let ob of GetStudents()) {
  console.log(`ID:${ob.Id} Name:${ob.Name} Age:${ob.Age}`);
}

let GetStudentById = (id) => {
  for (let ob of students) {
    if (ob.Id == id) return ob;
  }
  return null;
};
let obj = GetStudentById(789);
if (obj != null) {
  console.log(`ID:${obj.Id} Name:${obj.Name} Age:${obj.Age}`);
} else console.log("Invalid Id");
