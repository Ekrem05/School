using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka
{
    class ZooParkIterator : IEnumerator<Animal>

    {   public List<Animal> animals;
        public int Index = -1;

        public ZooParkIterator(IEnumerable<Animal> animals)
        {
            this.animals = animals.ToList();
        }
        
        public object Current => Current;

        Animal IEnumerator<Animal>.Current => animals[Index];

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            Index++;
            return Index < animals.Count;
        }

        public void Reset()
        {
            
        }
    }
}
