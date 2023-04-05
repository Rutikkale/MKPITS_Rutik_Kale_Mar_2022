using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class Student
    {
        int rollno;
        string name;
        int age;
        int standard;
        public void setStudent(int rollno,string name,int age,int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public void getStudent()
        {
            Console.WriteLine("Your Roll No is:{0}", this.rollno);
            Console.WriteLine("your name is:{0}",this.name);
            Console.WriteLine("your age is:{0}", this.age);
            Console.WriteLine("your standard is:{0}", this.standard);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your roll:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your standard");
            int standard = int.Parse(Console.ReadLine());

            Student rutik = new Student();
            rutik.setStudent(roll, name, age, standard);
            rutik.getStudent();

            Console.ReadLine();
        }
    }
}
