using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Helpers
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
