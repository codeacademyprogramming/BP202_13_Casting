using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 45;
            //imlicit convertion
            int num = age;
            //explicit convertion
            age = (byte)num;

            Human human = new Human();

            Student student = new Student();
            Teacher teacher = new Teacher();
            WarrantyStudent warrantyStudent = new WarrantyStudent();   

            //upcasting
            human = student;

            //downcasting
            student = human as Student;
            //student = (Student)human;

            Console.WriteLine("IS: "+(human is Student));

            student.Show();

            Console.WriteLine(age);


            //boxing
            num = 454;
            object numObj = "dfd";

            num = (int)numObj;
            Console.WriteLine(num);

        }
    }
}
