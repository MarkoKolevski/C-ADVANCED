using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(int iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }
    }
}
