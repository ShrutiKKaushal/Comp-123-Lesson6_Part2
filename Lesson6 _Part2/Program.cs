using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6__Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Tiger");
            Console.WriteLine(myCat.Speak());
            myCat.Eats();

            Dog myDog = new Dog("Conan");
            Console.WriteLine(myDog.Speak());


            myDog.Eats();
            Console.Write("\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            }
    }
}
