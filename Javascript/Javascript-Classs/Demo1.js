class Student {
  constructor(sid, sname, age, city) {
    //parameter constuctor
    this.sid = sid;
    this.sname = sname;
    this.age = age;
    this.city = city;
  }
  show() {
    console.log(
      `ID:${this.sid} Name:${this.sname} Age:${this.age} City:${this.city}`
    );
  }
}
let obj = new Student(1, "Faran", 12, "Delhi");
obj.show();
//array of students
let students = [
  new Student(12, "Rohan", 12, "Chennai"),
  new Student(12, "Rohan", 11, "Chennai"),
  new Student(13, "Rohan", 12, "Bangalore"),
  new Student(14, "Rohan", 11, "Chennai"),
  new Student(15, "Rohan", 12, "Bangloar"),
  new Student(16, "Rohan", 10, "Delhi"),
];
for (let stu of students) {
  stu.show(); //method defined in student class
}
