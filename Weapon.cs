using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public string Caliber { get; set; }
        public int NumberOfRounds { get; set; }
        public Weapon(string weaponName, string caliber, int bullets)
        {
            this.Name = weaponName;
            this.Caliber = caliber;
            this.NumberOfRounds = bullets;
        }
      

        public virtual void Fire(int bullets)
        {
            Console.WriteLine("Bang, bang!");
        }

        public virtual void Reload()
        {
            Console.WriteLine("Default: Weapon is Reloading..");
        }
    }

    public class M16 : Weapon
    {
        public M16(string weaponName, string caliber, int bullets) : base(weaponName, caliber, bullets)
        {
            Console.WriteLine($"The {weaponName} is a standard USMC issue. \n" +
                $"and it fires {caliber} caliber bullets");
        }

        public override void Fire(int bullets)
        {
            Console.WriteLine("Bam bam bam...");
            Console.WriteLine($"This rifle can house {bullets} bullets per magazine.");
        }

        public override void Reload()
        {
            Console.WriteLine("Insert magazine to reload!");
        }
    }

    public class SAW : Weapon
    {
        public SAW(string weaponName, string caliber, int bullets) : base(weaponName, caliber, bullets)
        {
            Console.WriteLine($"The {weaponName} is a standard USMC machinegun. \n" +
                $"and it fires {caliber} caliber bullets");
        }

        public override void Fire(int bullets)
        {
            Console.WriteLine("Tratratratratratra...");
            Console.WriteLine($"This machinegun can fire more than {bullets} bullets per second.");
        }

        public override void Reload()
        {
            Console.WriteLine("Insert belt to reload!");
        }
    }


    public class Motar : Weapon
    {
        public Motar(string weaponName, string caliber, int bullets) : base(weaponName, caliber, bullets)
        {
            Console.WriteLine($"The {weaponName} is a standard USMC issue. \n" +
                $"and it fires a {caliber} motar round");
            Console.WriteLine($"This weapon system can fire {bullets} motar at a time.");
        }

        public override void Fire(int bullets)
        {
            Console.WriteLine("plink............sssssssss BOOOOMM!");
            Console.WriteLine($"This weapon system can fire {bullets} motar at a time.");
        }

        public override void Reload()
        {
            Console.WriteLine("Insert round into muzzleloader!");
        }
    }
}