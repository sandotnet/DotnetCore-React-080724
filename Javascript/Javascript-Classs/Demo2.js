class Student {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }
  display() {
    console.log(this.name);
    console.log(this.age);
    console.log(this.city);
  }
}
var obj = new Student("sachin", 12);
obj.display();
var obj1 = new Student("Ram", 23);
obj1.display();
var obj2 = new Student("Virat", 12);
obj2.display();
