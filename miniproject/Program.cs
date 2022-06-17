using System;

namespace miniproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Baku baku = new Baku();
            string answer;
            do
            {
                
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Student elave et");
                Console.WriteLine("3. Employeelerin sayini goster");
                Console.WriteLine("4. Studentlerin sayini goster");
                Console.WriteLine("5. Employeelere bax");
                Console.WriteLine("6. Studentlere bax");
                Console.WriteLine("7. Insanlar uzere axtaris et");
                Console.WriteLine("0.Menudan cix");

                do
                {
                    answer = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(answer) || (answer!="1" && answer!="2"&& answer!="3" && answer!="4" && answer!="5"&& answer!="6" && answer!="7" && answer!="0"));


                switch (answer)
                {
                    case "1":
                       
                        Console.WriteLine("Employee-nin adini daxil edin:");
                        string empName = Console.ReadLine();
                        Console.WriteLine("Employee-nin soyadini daxil edin:");
                        string empSurname = Console.ReadLine();
                        Console.WriteLine("Employee-nin yasini daxil edin:");
                        string empAgeStr = Console.ReadLine();
                        int empAge = Convert.ToInt32(empAgeStr);
                        Console.WriteLine("Employee-nin vezifesini daxil edin:");
                        string empPosition = Console.ReadLine();
                            Human emp1;
                        baku.AddHuman(emp1);
                        Console.WriteLine("Human elave olundu");
                        break;
                    case "2":
                        Console.WriteLine("Student-in adini daxil edin:");
                        string stdName = Console.ReadLine();
                        Console.WriteLine("Student-in soyadini daxil edin:");
                        string stdSurname = Console.ReadLine();
                        Console.WriteLine("Student-in yasini daxil edin:");
                        string stdAgeStr = Console.ReadLine();
                        int stdAge = Convert.ToInt32(stdAgeStr);
                        Console.WriteLine("Student-in qiymetini daxil edin:");
                        string stdGradeStr = Console.ReadLine();
                        double stdGrade = Convert.ToDouble(stdGradeStr);
                        Console.WriteLine("Student-in qrup nomresini daxil edin:");
                        string stdGroupNo = Console.ReadLine();
                        Human std1;
                        baku.AddHuman(std1);
                        Console.WriteLine("Human elave olundu");
                        break;
                    case "3":
                        Human[] onlyEmployees = baku.GetEmployees();
                        Console.WriteLine(onlyEmployees);
                        break;
                    case "4":
                        Human[] onlyStudents = baku.GetStudents();
                        Console.WriteLine(onlyStudents);
                        break;
                    case "5":
                        Human[] employeesArr = baku.GetEmployees();
                        foreach (var item in employeesArr)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "6":
                        Human[] studentsArr = baku.GetStudents();
                        foreach (var item in studentsArr)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Axtaris deyerini daxil edin:");
                        string searchedText = Console.ReadLine();
                   



                    default:
                        break;
                }
            } while (answer!="0");
            







        }
    }
}
