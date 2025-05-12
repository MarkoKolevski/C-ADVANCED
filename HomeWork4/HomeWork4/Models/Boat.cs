using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Jas sum brod nemam trkala:(");
        }

        public void Sail()
        {
            Console.WriteLine("Brodot plovi");
        }
    }
}
