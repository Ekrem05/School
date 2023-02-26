using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka
{
    class Animal:IComparable<Animal>
    {
        public Animal(string name, int age, params string[] children)
        {
            Name = name;
            Age = age;
            Children = children.ToList();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Children { get; set; }

        public int CompareTo(Animal other)
        {
            int result = other.Age.CompareTo(this.Age);
            if (result==0)
            {
                result = this.Name.CompareTo(other.Name);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }

    }
}
