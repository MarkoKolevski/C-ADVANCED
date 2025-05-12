using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Models
{
   public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Jas sum kola imam cetiri trkala:)");
        }

        public void Drive()
        {
            Console.WriteLine("Kolata vozi");
        }
    }
}
