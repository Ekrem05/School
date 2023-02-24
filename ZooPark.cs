using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka
{
    class ZooPark:IEnumerable<Animal>
    {
        public List<Animal> animals;
        public ZooPark(params Animal[]animals)
        {
            this.animals = animals.ToList();
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new ZooParkIterator(animals);
        }
    

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
