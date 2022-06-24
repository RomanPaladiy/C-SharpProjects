using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class RandomClass
    {
        private int id;
        private string name;

        public RandomClass() : this(0, "")
        {
        }

        public RandomClass(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public RandomClass(int id) : this(id, "")
        {
        }

        public RandomClass(string name) : this(0, name)
        {
        }
    }
}
