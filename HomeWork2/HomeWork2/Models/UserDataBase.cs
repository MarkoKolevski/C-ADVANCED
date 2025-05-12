using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Models
{
   public class UserDataBase
    {
        public static User[] Users = new User[]
           {
            new User(1, "Marko", 21),
            new User(2, "Jovan", 17),
            new User(3, "Ognen", 27)
           };

        public static User[] Search(int id, string name, int age)
        {
            return Users.Where(u => u.ID == id && u.Name == name && u.Age == age).ToArray();
        }
    }
}
