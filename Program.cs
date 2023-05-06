using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Author: Yanzhi Wang
// Purpose: Main program that creates instances of different pets, adds them to a pet list, and performs random actions on them
// Restrictions: None known

namespace PetApp
{
    // Class: Program
    // Purpose: The main entry point for the application. Creates pets and allows them to perform actions.
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: The entry point of the application. Creates instances of pets and allows them to perform actions.
        static void Main(string[] args)
        {
            // Declare variables
            string name;
            int age;
            string license;

            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            // Loop to create pets and have them perform actions
            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance to create a new pet
                if (rand.Next(1, 11) == 1)
                {
                    // 50/50 chance to create a dog or a cat
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's Name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        while (true)
                        {
                            try
                            {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.Write("Age => ");
                            }
                        }
                        Console.Write("License => ");
                        license = Console.ReadLine();

                        // Create a new dog object and assign it to the Pet variable
                        thisPet = new Dog(license, name, age);

                    }
                    else
                    {
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's Name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        while (true)
                        {
                            try
                            {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.Write("Age => ");
                            }
                        }

                        // Create a new cat object and assign it to the Pet variable
                        cat = new Cat();
                        thisPet = cat;
                        thisPet.Name = name;
                        thisPet.age = age;
                    }
                }
                else // If not creating a new pet, choose a random pet from the list
                {
                    thisPet = pets[rand.Next(0, pets.Count)];
                }

                if (thisPet != null)
                {
                    // If the pet is a cat, cast it to an ICat interface and have it perform a random action
                    if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (ICat)thisPet;
                        int choice = rand.Next(0, 4);

                        if (choice == 0)
                        {
                            iCat.Eat();
                        }
                        else if (choice == 1)
                        {
                            iCat.Play();
                        }
                        else if (choice == 2)
                        {
                            iCat.Scratch();
                        }
                        else
                        {
                            iCat.Purr();
                        }

                    }
                    else
                    {
                        // Cast the pet to an IDog interface
                        iDog = (IDog)thisPet;

                        // Randomly choose an action to perform on the dog
                        int choice = rand.Next(0, 5);

                        // Perform the action based on the randomly chosen value
                        if (choice == 0)
                        {
                            iDog.Eat();
                        }
                        else if (choice == 1)
                        {
                            iDog.Play();
                        }
                        else if (choice == 2)
                        {
                            iDog.Bark();
                        }
                        else if (choice == 3)
                        {
                            iDog.NeedWalk();
                        }
                        else
                        {
                            iDog.GotoVet();
                        }
                    }
                }
            }
        }
    }
}