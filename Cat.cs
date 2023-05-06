using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Cat
    //Purpose: Give blueprints for creation of instance of Cat or run called methods
    class Cat : Pet, ICat
    {
        public Cat() { }

        //Method: Eat
        //Purpose: Print a line
        public override void Eat()
        {
            Console.WriteLine(Name + ": No I want your food, not this garbage!");
        }

        //Method: Play
        //Purpose: Print a line
        public override void Play()
        {
            Console.WriteLine(Name + ": Where's that mouse...");
        }

        //Method: Purr
        //Purpose: Print a line
        public void Purr()
        {
            Console.WriteLine(Name + ": Purrr purrr...");
        }

        //Method: Scratch
        //Purpose: Print a line
        public void Scratch()
        {
            Console.WriteLine(Name + ": Hisss!");
        }

        //Method: GotoVet
        //Purpose: Print a line
        public override void GotoVet()
        {
            Console.WriteLine(Name + ": No I don't think so, I'm comfy here.");
        }
    }
}
