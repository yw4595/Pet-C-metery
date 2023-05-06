using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Dog
    //Purpose: Give blueprints for creation of instance of Dog or run called methods
    class Dog : Pet, IDog
    {
        public string license;

        public Dog(string szLicense, string szName, int nAge) :
            base(szName, nAge)
        {
            this.license = szLicense;
        }

        //Method: Eat
        //Purpose: Print a line
        public override void Eat()
        {
            Console.WriteLine(Name + ": Yummy! Thanks!");
        }

        //Method: Play
        //Purpose: Print a line
        public override void Play()
        {
            Console.WriteLine(Name + ": Throw it! Pleaseeee!");
        }

        //Method: Bark
        //Purpose: Print a line
        public void Bark()
        {
            Console.WriteLine(Name + ": Woof, woof");
        }

        //Method: NeedWalk
        //Purpose: Print a line
        public void NeedWalk()
        {
            Console.WriteLine(Name + ": ~whimpers and whines~");
        }

        //Method: GotoVet
        //Purpose: Print a line
        public override void GotoVet()
        {
            Console.WriteLine(Name + ": ~whimpers and whines~ No vet please!");
        }
    }
}
