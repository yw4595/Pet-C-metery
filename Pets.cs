using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    // Class: Pets
    // Purpose: Encapsulates a list of pets and provides methods for adding, removing, and accessing them
    public class Pets
    {
        // Field: petList
        // Purpose: The list of pets
        public List<Pet> petList = new List<Pet>();

        // Indexer: this[]
        // Purpose: Allows the caller to get or set a pet at a specific index in the petList
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    // Try to get the pet at the specified index
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    // If the index is invalid, return null
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // If the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // Update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // Add the value to the list
                    petList.Add(value);
                }
            }
        }

        // Property: Count
        // Purpose: Returns the number of pets in the petList
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        // Method: Add
        // Purpose: Adds a pet to the petList
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        // Method: Remove
        // Purpose: Removes a pet from the petList
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        // Method: RemoveAt
        // Purpose: Removes a pet from the petList based on its index
        public void RemoveAt(int petEI)
        {
            petList.RemoveAt(petEI);
        }
    }
}
