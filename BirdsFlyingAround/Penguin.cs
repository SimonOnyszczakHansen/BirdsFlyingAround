using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    internal class Penguin : Bird, IHunt, IDiveUnderWater
    {
        public Penguin(string name, string gender)
            : base(name, gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public string Hunt()
        {
            return "The penguin hunts its prey";
        }
        public override string Eat()
        {
            return "The penguin eats its prey";
        }
        public string DiveUnderWater()
        {
            return "The penguin dives under water";
        }
    }
}
