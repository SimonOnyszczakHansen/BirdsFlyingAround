using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    internal class Eagle : Bird, IFly, IDiveUnderWater, IHunt
    {
        public Eagle(string name, string gender)
            : base(name, gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public string Hunt()
        {
            return "The eagle hunts its prey";
        }
        public override string Eat()
        {
            return "The eagle eats its prey";
        }
        public string Fly()
        {
            return "The eagle flies away";
        }
        public string DiveUnderWater()
        {
            return "The eagle is diving under water";
        }
    }
}
