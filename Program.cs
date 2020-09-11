using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateUnit();
        }

        public static void CreateUnit()
        {
            try
            {
                Personnel coCaptain = new Captain("Captain", "Female", "USMC");
                coCaptain.Command = "3rd Combat Engineer Batallion";
                coCaptain.Salute("3rd Combat Engineer Batallion");
                coCaptain.Shoot();
                coCaptain.Trains();

                Console.WriteLine();

                Vehicle my7Ton = new SevenTon("SevenTon", 4);
                my7Ton.StartEngine(6);
                my7Ton.Accelerate();
                my7Ton.Brake();
                my7Ton.Mount();

                Console.WriteLine();

                Weapon myRifle = new M16("M16", ".556", 0);
                myRifle.Fire(30);
                myRifle.Reload();

            }
            catch (Exception ex)              //Handles any execption
            {
                Console.WriteLine(ex.Message);
                CreateUnit();
            }
            finally
            {
                Console.WriteLine("Semper Fi");
            }
        }
    }
}
