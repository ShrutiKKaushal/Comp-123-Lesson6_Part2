using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6__Part2
{
    abstract class Animal : IEats
    {
        //Private  instance variable +++++++++++++++++++++
        private string _name;

        //Public Properties ++++++++++++++++++++++++++++++
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        // Public Constructor ++++++++++++++++++++++++++++
        public Animal(string name)
        {
            this._name = name;
        }

        // Abstract Methods +++++++++++++++++++++++++++++++
        public abstract string Speak();



        // Public Methods ++++++++++++++++++++++++++++++++++
        public abstract void Eats();
    
    }
}
