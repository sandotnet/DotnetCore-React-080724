using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Student //Model
    {
        public int studentId;
        public string studentName;
        public int age;
    }
    class StudentRepository
    {
        Student[] students = new Student[5];
        int idx = 0;
        public void AddStudent(Student student)
        {
            if (idx < students.Length)
            {
                students[idx] = student;
                idx++;
            }else
            {
                Console.WriteLine("Class is Full!!");
            }
        }
        public Student GetStudent(int id)
        {
            foreach(Student s in students)
            {
                if (s != null)
                {
                    if (s.studentId == id)
                    {
                        return s;
                    }
                }
            }
            return null;

        }
        public Student[] GetAllStudents()
        {
            return students;
        }
    }

    class Demo4
    {
        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            do
            {
                Console.WriteLine("1. AddStudent");
                Console.WriteLine("2.GetStudentById");
                Console.WriteLine("3.GetAllStudents");
                Console.WriteLine("4.Exit App");
                Console.WriteLine("Enter U r Choice");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: //Add New Student Details
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter Id");
                            student.studentId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            student.studentName = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            student.age = int.Parse(Console.ReadLine());
                            studentRepository.AddStudent(student);
                        }
                        break;
                    case 2: //Get Student By Id
                        {
                            Console.WriteLine("Enter Student Id");
                            int id = int.Parse(Console.ReadLine());
                            Student student=studentRepository.GetStudent(id);
                            if (student != null)
                            {
                                Console.WriteLine($"Id:{student.studentId} Name:{student.studentName} Age:{student.age}");
                            }
                            else
                                Console.WriteLine("Invalid id");
                        }
                        break;
                    case 3: //Get All Students
                        {
                            Student []students=studentRepository.GetAllStudents();
                            foreach(var student in students)
                            {
                                if(student!=null)
                                Console.WriteLine($"Id:{student.studentId} Name:{student.studentName} Age:{student.age}");
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0); //close app
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");break;
                }
            } while (true);
        }
    }
}
