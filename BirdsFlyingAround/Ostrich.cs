using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    internal class Ostrich : Bird
    {
        public Ostrich(string name, string gender)
            : base(name, gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public override string Eat()
        {
            return "The ostrich eats";
        }
    }
}
