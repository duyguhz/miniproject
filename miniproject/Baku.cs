using System;
namespace miniproject
{
    public class Baku:ICity
    {
        public Baku()
        {
        }

        public Human[] humans = new Human[0];

        Human[] ICity.humans { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddHuman(Human human)
        {
            Array.Resize(ref humans, humans.Length + 1);
                humans[humans.Length - 1] = human;
        }

       
        public Human[] GetStudents()
        {
            Human[] onlyStudents = new Human[0];
            for (int i = 0; i < humans.Length; i++)
            {
                if (humans[i] is Student)
                {
                    Array.Resize(ref onlyStudents, onlyStudents.Length + 1);
                    onlyStudents[onlyStudents.Length - 1] = humans[i];
                }
            }
            return onlyStudents;
        }
        public Human[] GetEmployees()
        {
            Human[] onlyEmployees = new Human[0];
            for (int i = 0; i < humans.Length; i++)
            {
                if (humans[i] is Student)
                {
                    Array.Resize(ref onlyEmployees, onlyEmployees.Length + 1);
                    onlyEmployees[onlyEmployees.Length - 1] = humans[i];
                }
            }
            return onlyEmployees;
        }
        public Human[] SearchHumans(string text)
        {
            Human[] newArr = new Human[0];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (humans[i].Name.Contains(text) || humans[i].Surname.Contains(text))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = newArr[i];
                }
            }
            return newArr;
        }

    }
}
