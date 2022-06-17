using System;
namespace miniproject
{
    public class Student:Human
    {
       public Student(string name,string surname) : base(name, surname)
        {

        }
        public string GroupNo;
        public double Grade;
        public override void ShowInfo()
        {
            Console.WriteLine("Name:{Name} Surname:{Surname} Age:{Age} GroupNo:{GroupNo} Grade: {Grade}");
        }
    }
}
