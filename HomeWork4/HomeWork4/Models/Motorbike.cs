using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Models
{
    public class Motorbike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Jas sum motor imam dve trkala :)");
        }

        public void Wheelie()
        {
            Console.WriteLine("Motorot vozi na edno trkalo");
        }
    }
}
