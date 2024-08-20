using Inheritance;
using System;

namespace InheritancePratik
{
    class program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Ad = "aa";
            student1.Soyad = "bb";
            student1.studentNumber = 13;

            Console.WriteLine("Öğrenci Bilgileri:");
            student1.studentInfo();


            Teacher teacher1= new Teacher();
            teacher1.Ad = "cc";
            teacher1.Soyad = "dd";
            teacher1.Profession = "ee";

            Console.WriteLine("Öğretmen Bilgileri:");
            teacher1.teacherInfo();
        }
    }
}