using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create four objects. You decide on the arguments
            Pet Thunder = new Pet("Thunder", 1, "A male guinea pig.");
            Pet North = new Pet("North", 5, "A male husky.");
            Pet Kitty = new Pet("Kitty", 2, "A female cat.");
            Pet Owow = new Pet("Owow", 1, "A female chicken.");

            //Create a List to store all the above objects.
            List<Pet> farmPets = new List<Pet> { Thunder, North, Kitty, Owow };

            //Use some of the methods on some of the objects.
            Kitty.Train();
            Thunder.SetOwner("Sophia");
            Kitty.SetOwner("Sophia");
            North.SetOwner("George");

            //Using a suitable looping statement, display all the objects in the collection.
            foreach (Pet pet in farmPets)
            {
                Console.WriteLine($"\n{pet}");
            }
            Console.WriteLine();
            //Prompt the user for an owner’s name and then display only the pets belonging to a particular person.
            Console.WriteLine("Enter an owner's name:");
            string ownerName = Console.ReadLine();
            int counter = 0;
            List<string> theirPet = new List<string>();
            foreach(Pet pet in farmPets)
            {
                if (pet.GetOwner() == ownerName)
                {

                    theirPet.Add(pet.GetName());
                    counter++;
                }
            }
            Console.WriteLine(string.Join(",", theirPet));
            Console.WriteLine($"{ownerName} has {counter} pet{(counter<=1?"":"s")}.");
        }
    }
    class Pet
    {
        string Name;
        private string Owner;
        int Age;
        string Description;
        private bool IsHouseTrained;

        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "No one";
            IsHouseTrained = false;
        }

        public override string ToString()
        {
            return $"{Owner}'s pet {Name} \n------------- \n{Age} years old / {(IsHouseTrained? "":"not")} trained. \nDescription: {Description}";
        }

        public void Train()
        {
            IsHouseTrained = true;
        }

        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }
        public string GetOwner()
        {
            return Owner;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
