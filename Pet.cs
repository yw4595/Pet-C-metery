using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Pet
    //Purpose: Abstract class for general Pet creation
    public abstract class Pet
    {
        private string name;
        public int age;

        // Property: Name
        // Purpose: Get or set the pet name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Abstract method: Eat
        // Purpose: Print a line, the implementation of this method will vary depending on the pet
        public abstract void Eat();

        // Abstract method: Play
        // Purpose: Print a line, the implementation of this method will vary depending on the pet
        public abstract void Play();

        // Abstract method: GotoVet
        // Purpose: Print a line, the implementation of this method will vary depending on the pet
        public abstract void GotoVet();

        // Default constructor
        public Pet() { }

        // Parameterized constructor
        // Purpose: Set the name and age of the pet when it is created
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
