using HomeWork4.Helpers;
using HomeWork4.Models;

namespace HomeWork4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle motorbike = new Motorbike();
            Vehicle boat = new Boat();
            Vehicle plane = new Airplane();

            car.DisplayInfo();
            motorbike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();

            ((Car)car).Drive();
            ((Motorbike)motorbike).Wheelie();
            ((Boat)boat).Sail();
            ((Airplane)plane).Fly();

            List<string> stringsList = new()
            {
                 "Marko", "Jovan", "Ognen", "Vojdan"
             };

            PrintInConsole printInConsole = new();

            printInConsole.Print(1234);
            printInConsole.Print("Jas sum string");
            printInConsole.Print(true);

            printInConsole.PrintCollection(stringsList);
        }
    }
}
