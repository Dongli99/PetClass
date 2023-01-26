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

            Pet Thunder = new Pet("Thunder", 1, "A curious guinea pig.");
            Pet North = new Pet("North", 5, "An energetic husky.");
            Pet Kitty = new Pet("Kitty", 2, "A quiet cat.");
            Pet Owow = new Pet("Owow", 1, "An annoying hen.");
;
            //Create a List to store all the above objects.

            List<Pet> farmPets = new List<Pet> { Thunder, North, Kitty, Owow };

            //Use some of the methods on some of the objects.

            Kitty.Train();
            Thunder.SetOwner("Sophia");
            Kitty.SetOwner("Sophia");
            North.SetOwner("George");

            //Using a suitable looping statement, display all the objects in the collection.

            foreach (Pet pet in farmPets)
                Console.WriteLine($"\n{pet}");

            //Prompt the user for an owner’s name and then display only the pets belonging to a particular person.
            Console.WriteLine();
            Console.WriteLine("Enter an owner's name:");
            string ownerName = Console.ReadLine();

            int counter = 0;
            List<string> theirPet = new List<string>();
            foreach(Pet pet in farmPets)
            {
                if (pet.Owner == ownerName)
                {

                    theirPet.Add(pet.Name);
                    counter++;
                }
            }
            Console.Write($"{ownerName} has {counter} pet{(counter <= 1 ? "" : "s")}: ");
            Console.WriteLine(string.Join(", ", theirPet));
        }
    }
    class Pet
    {
        public string Name { get; }
        public string Owner { get; private set; }
        public int Age { get; }
        public string Description { get; }
        public bool IsHouseTrained { get; private set; }
        public void SetOwner(string newOwner)
        {
            Owner= newOwner;
        }
        public void Train()
        {
            IsHouseTrained= true;
        }
        public Pet(string Name, int Age, string Description)
        {
            this.Name = Name;
            this.Age = Age;
            this.Description = Description; 
            Owner = "No one";
            IsHouseTrained = false;
        }
        public override string ToString()
        {
            return $"{Owner}'s pet: {Name} \n---------------------- \n{Age} years old / {(IsHouseTrained? "":"Not")} Trained. \nDescription - {Description}";
        }
    }
}
