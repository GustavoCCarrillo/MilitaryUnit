using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public abstract class Vehicle
    {
        public int Tires { get; set; }
        public string Name { get; set; }
        public Vehicle(string vehicleModel, int wheels)
        {
            this.Name = vehicleModel;
            this.Tires = wheels;
        }
      

        public virtual void StartEngine(int wheels)
        {
            Console.WriteLine("Rrmm rmm");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("The car is speeding up..");
        }

        public virtual void Brake()
        {
            Console.WriteLine("The car is slowing down...");
        }

        public virtual void Mount()
        {
            Console.WriteLine("The mount of the vehicle.");
        }
    }

    public class Humvee : Vehicle
    {
        public Humvee(string vehicleModel, int wheels) : base(vehicleModel, wheels)
        {
            Console.WriteLine($"The {vehicleModel} is a standard USMC vehicel. \n" +
                $"It can be up-armored or lightweight for normal driving.");
        }

        public override void StartEngine(int wheels)
        {
            Console.WriteLine("eeehh eeehhh eeehh rmm rmm...");
            Console.WriteLine($"This vehicle has {wheels} tires");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The humvee is speed up!");
        }

        public override void Brake()
        {
            Console.WriteLine("Humvee is slowing down...(brakes screeching)");
        }

        public override void Mount()
        {
            Console.WriteLine("The Humvee has a wepaons mount on top of the roof for a 50 caliber machine gun.");
        }
    }

    public class SevenTon : Vehicle
    {
        public SevenTon(string vehicleModel, int wheels) : base(vehicleModel, wheels)
        {
            Console.WriteLine($"The {vehicleModel} is a standard USMC semi-vehicle. \n" +
                $"It can haul over 7 tons of weight up steep climbs");
        }

        public override void StartEngine(int wheels)
        {
            Console.WriteLine("Tsk tsk Rmmm rmmm...");
            Console.WriteLine($"This vehicle has {wheels} tires");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The SevenTon is speeding up slowly..");
        }

        public override void Brake()
        {
            Console.WriteLine("The SevenTon is slowing down too slowly...");
        }

        public override void Mount()
        {
            Console.WriteLine("The 7ton has a weapons mount on top of the drivers cabin for a 50 caliber machinegun.");
        }
    }

    public class CobraHelicopter : Vehicle
    {
        public CobraHelicopter(string vehicleModel, int wheels) : base(vehicleModel, wheels)
        {
            Console.WriteLine($"The {vehicleModel} is a powerful war machine. \n" +
                $"It can fire 50 caliber rounds and misiles.");
        }

        public override void StartEngine(int wheels)
        {
            Console.WriteLine("chuff chuff chuff chuff...");
            Console.WriteLine($"This vehicle has no tires since it is an aircraft.");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The Cobra speeds up...");
        }

        public override void Brake()
        {
            Console.WriteLine("The Cobra helicopter slows down to a hover..");
        }

        public override void Mount()
        {
            Console.WriteLine("Weapons are mounted on each wide-side of the Cobra helicopter");
        }
    }
}
