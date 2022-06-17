using System;
namespace miniproject
{
    public class Employee:Human
    {
        public Employee(string name,string surname):base(name,surname)
        {
        }
        public string Position;
        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} Position: {Position}");
        }
        
    }
}
