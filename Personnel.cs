using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public abstract class Personnel
    {
        public string Rank { get; set; }
        public string Gender { get; set; }
        public string Command { get; set; }
        public Personnel(string rank, string gender, string unit)
        {
            this.Rank = rank;
            this.Gender = gender;
            this.Command = unit;
        }
        

        public virtual void Salute(string unit)
        {
            Console.WriteLine($"The {Rank} Solutes his commanding officer.");
        }

        public virtual void Trains()
        {
            Console.WriteLine($"The {Rank} trains the junior Marines combat skills");
        }

        public virtual void Shoot()
        {
            Console.WriteLine("Bang Bang is the standard sound");
        }


    }

    public class Sargeant : Personnel
    {
        public Sargeant(string rank, string gender, string unit) : base(rank, gender,unit)
        {
            Console.WriteLine($"The {rank} is the fifth rank in the Marine Corps. \n" +
                $"It its a position of great responsibility.");
            Console.WriteLine($"This Marine belongs to the {unit}");
        }

        public override void Salute(string unit)
        {
            Console.WriteLine("The sargeant salutes with the right hand to the right-side forehead.");
            Console.WriteLine($"This Marine belongs to the {unit}");
        }

        public override void Trains()
        {
            Console.WriteLine("The sargeat trains in the Marine Corps Martial Arts Program.");
        }

        public override void Shoot()
        {
            Console.WriteLine("Deep, long breath....aim...Shoot! tratratrata!");
        }
    }

    public class Captain : Personnel
    {
        public Captain(string rank, string gender, string unit) : base(rank, gender,unit)
        {
            Console.WriteLine($"The rank of {rank} is the third rank in the Marine Corps officer ranking system. \n" +
                $"A {rank} is in charge of an entire company which is made up of over 200 Marines.");
        }

        public override void Salute(string unit)
        {
            Console.WriteLine("The captain salutes any military personnel whom salutes first.");
            Console.WriteLine($"This Marine belongs to the {unit}");
        }

        public override void Trains()
        {
            Console.WriteLine("The captain orders sargeants to train junior Marines.");
        }

        public override void Shoot()
        {
            Console.WriteLine("Deep, long breath....aim...Shoot! tratratrata!");
        }
    }


    public class Private : Personnel
    {
        public Private(string rank, string gender, string unit) : base(rank, gender,unit)
        {
            Console.WriteLine($"The rank of {rank} is the first rank of the enlisted side. \n" +
                $"and it is the worst rank to be at.");
            Console.WriteLine($"This Marine belongs to the {unit}");
        }

        public override void Salute(string unit)
        {
            Console.WriteLine("The private must salute at any officer in sight");
            Console.WriteLine($"This Marine belongs to the {unit}");
        }

        public override void Trains()
        {
            Console.WriteLine("Privates are trained by their sargeants ordered by their captain.");
        }

        public override void Shoot()
        {
            Console.WriteLine("Deep, long breath....aim...Shoot! tratratrata!");
        }
    }
}
