using System;
using System.Collections.Generic;

namespace podgotovka
{
    class Program
    {
        public static void Main()
        { Action<List<Animal>> action = x =>
            {
                x.Sort();
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
                
            };
            Animal animalOne = new Animal("Charly", 5, "Maks");
            Animal animalTwo = new Animal("Leon", 4, "Surga", "Manu");
            Animal animalThree = new Animal("Oto", 9);
            Animal animalFoor = new Animal("Kari", 5, "Maksim");
            Animal animalFive = new Animal("Kara", 4, "Scharo", "Sara");           
            ZooPark zooparkOne = new ZooPark();
            ZooPark zooparkTwo = new ZooPark(animalOne, animalTwo, animalThree, animalFoor, animalFive);
            List<Animal> animals = new() { animalOne, animalTwo, animalThree, animalFoor, animalFive };
            animals.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(new string('-',20));
            Console.WriteLine();           
           action(animals);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine();
            AnimalComparator comparator = new(animals);
            comparator.animals.Sort(comparator);
            comparator.animals.ForEach(x => Console.WriteLine(x));
        }

    }
}
