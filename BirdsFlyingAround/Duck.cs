using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    internal class Duck : Bird, IFly, IDiveUnderWater
    {
        public Duck(string name, string gender)
            : base (name, gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public override string Eat()
        {
            return "The duck eats";
        }
        public string Fly()
        {
            return "The duck flies away";
        }
        public string DiveUnderWater()
        {
            return "The duck dives under water";
        }
    }
}
