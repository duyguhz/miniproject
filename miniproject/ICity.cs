using System;
namespace miniproject
{
    public interface ICity
    {
        Human[] humans { get; set; }
        public abstract void AddHuman(Human human);
        public abstract Human[] SearchHumans(string text);


    }
}
