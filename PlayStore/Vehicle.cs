using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public abstract class Vehicle
    {
        public abstract void startEngine();
        public abstract void stopEngine();
    }
    public class Car : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Car Engine has started");
        }

        public override void stopEngine()
        {
            Console.WriteLine("Car Engine has Stopped");
        }
    }
    public class MotorCycle : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("The Bike has started");
        }
        public override void stopEngine()
        {
            Console.WriteLine("The Bike has stopped");
        }
    }
}