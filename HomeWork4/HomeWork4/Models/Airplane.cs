using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine(" Jas sum avion imam povekje trkala:)");
        }

        public void Fly()
        {
            Console.WriteLine("Avionot leta");
        }
    }
}
