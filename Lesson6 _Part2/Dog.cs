using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6__Part2
{
    class Dog : Animal
    {
        // Constructor +++++++++++++++++
        public Dog(string name) : base(name)
        {

        }

        // Public Methods ++++++++++++++++
        public override string Speak()
        {
            return this.Name + " says Woof";
        }

        public override void Eats()
        {
            Console.WriteLine("{0} is eating", this.Name);
        }
    }
}
