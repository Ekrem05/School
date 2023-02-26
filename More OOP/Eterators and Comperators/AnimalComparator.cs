using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka
{
    class AnimalComparator : IComparer<Animal>
    {
        public List<Animal> animals = new List<Animal>();

        public AnimalComparator(List<Animal> animals)
        {
            this.animals = animals;
        }

        public int Compare(Animal x, Animal y)
        {
            int result = x.Name.CompareTo(y.Name);
            if (result == 0)
            {
                result = y.Age.CompareTo(x.Age);
            }
            return result;
        }
    }
}
