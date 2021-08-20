using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(4 , "Mercedez-Benz");
            Vehicle bicycle = new Vehicle();
            bicycle.number_of_wheels = 2;
            bicycle.name = "Bike";



            car.ReturnInfo();
            bicycle.ReturnInfo();

            Vehicle tank = new Vehicle(2 , "Tank");
            tank.ReturnInfo();

        }
    }

    class Vehicle
    {
        public string name;
        public int number_of_wheels;

        public Vehicle()
        {

        }

        public Vehicle(int number_of_wheels, string name)
        {
            this.number_of_wheels = number_of_wheels;
            this.name = name;
        }

        public void ReturnInfo()
        {
            Console.Write($"The name of the vehicle is {name}. The number of wheels of the vehicle is {number_of_wheels}.\n");
        }
    }
}
