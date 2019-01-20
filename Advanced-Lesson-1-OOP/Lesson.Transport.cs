using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public static partial class Lesson
    {

        public static void InheritanceTransportExample()
        {
            Transport transport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            var transport2 = new Transport { Distance = 34, MaxSpeed = 5 };

            Transport unknowedTransport = new Transport { Distance = 34, MaxSpeed = 5 };
            unknowedTransport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            //var fuel = unknowedTransport.Fuel;

            FuelCar maserati = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            Transport winner = maserati;
            FuelCar firstPlace = (FuelCar)winner;

            var transport3 = new Car() { Engine = 2.0 };
            var transport4 = new Car() { Engine = 1.6 };

            bool result = transport3 > transport4;
            Console.WriteLine(result);

            var transport5 = new Car() { Engine = 1.8 };
            bool result2 = transport5 < transport4;
            Console.WriteLine(result2);

            bool result3 = transport3 == transport5;
            Console.WriteLine(result3);
            bool result4 = transport4 != transport5;
            Console.WriteLine(result4);

        }   
    }

    public class Transport
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public int MaxSpeed { get; set; }
        public float Distance { get; set; }

        public virtual void Move(float km)
        {
            this.Distance += km;
        }
    }

    public class Car : Transport
    {
        public double Engine { get; set; }

        public static bool operator > (Car c1, Car c2)
        {
            return  c1.Engine > c2.Engine;
        }

        public static bool operator <(Car c1, Car c2)
        {
            return c1.Engine > c2.Engine;
        }
    }

    public class FuelCar : Car
    {
        public int Tank { get; set; }
        public float Fuel { get; set; }
        public float FuelUsage { get; set; }

        public override void Move(float km)
        {
            base.Move(km);
            this.Fuel -= km * FuelUsage / 100;
        }
    }

    public class ElectroCar : Car
    {
        public int Battery { get; set; }
        public float Charged { get; set; }
        public float DistanceBattery { get; set; }

        public override void Move(float km)
        {
            base.Move(km);
            this.Charged -= Battery * km / DistanceBattery;
        }
    }

}
