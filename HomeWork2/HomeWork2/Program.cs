using HomeWork2.Models;

namespace HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region task1
            // Create class User that will have 3 properties Id, Name, Age. Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list). Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
            User[] users = UserDataBase.Search(id: 2, name: "Jovan", age: 17);
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.ID}, Name: {user.Name}, Age: {user.Age}");
            }
            #endregion
            Console.WriteLine("==========");

            #region task2
            // Create a class Vehicle that have one method DisplayInfo(). Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method;
            Vehicle car = new Car();
            Vehicle motorBike = new Motorbike();
            Vehicle boat = new Boat();
            Vehicle plane = new Airplane();

            car.DisplayInfo();
            motorBike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();
            #endregion


        }
    }
}
