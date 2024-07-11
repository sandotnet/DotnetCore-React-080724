using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Person

    {

    }

    class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Hello " + name;
        }
    }
    class Demo9
    {
        static void Main()
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Student obj = new Student("Virat");
            Console.WriteLine(obj.ToString());


        }
    }
}
