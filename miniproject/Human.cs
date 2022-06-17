using System;
namespace miniproject
{
    public class Human
    {
        public Human(string name,string surname)
        {
            _name = name;
            _surname = surname;
        }
        private string _name;
        private string _surname;
        public int Age;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{_name}-Surname:{_surname}-Age:{Age}");
        }


        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (CheckSurname(value))
                {
                    _surname = value;
                }
            }
        }
        public bool CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckSurname(string surname)
        {
            for (int i = 0; i < surname.Length; i++)
            {
                if (!char.IsLetter(surname[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
