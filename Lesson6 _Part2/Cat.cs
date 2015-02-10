using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6__Part2
{
    class Cat : Animal
    {
        // Constructor +++++++++++++++++
        public Cat(string name) : base(name)
        {

        }

        // Public Methods ++++++++++++++++
        public override string Speak()
        {
            return this.Name + " says meow";
        }

        public override void Eats()
        {
            Console.WriteLine("{0} can't eat, she has a stomach problem", this.Name);
        }
    }
}
