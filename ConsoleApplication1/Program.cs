using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Facade
    {
         void Hello()
        {
            Console.Write("Hello");
        }
        void World()
        {
            Console.Write("World");
        }
         void Tab()
        {
            Console.Write("  ");
        }
        public void HelloWorld()
        {
            Hello();
            Tab();
            World();
            Console.WriteLine("");
        }

    }
    class Program
    {
        static void Main(string[] args)

        {
            Facade fc = new ConsoleApplication1.Facade();
            fc.HelloWorld();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
