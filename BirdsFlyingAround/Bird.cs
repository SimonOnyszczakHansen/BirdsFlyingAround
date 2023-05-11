using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    public abstract class Bird
    {
        protected string name;
        protected string gender;
        protected Bird(string name, string gender) 
        {
            this.name = name;
            this.gender = gender;
        }

        public abstract string Eat();
    }
}
