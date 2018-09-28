using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Kitten : Pet
    {
        private string toy;

        public Kitten(string name, string color, string food, string p_breed, string toy)
            : base(name, color, food, p_breed)
        {
            this.toy = toy;
        }

        public void PlayWithToy()
        {
            Console.WriteLine("{1} play's with {0}!!!", toy, name);
        }
    }
}
