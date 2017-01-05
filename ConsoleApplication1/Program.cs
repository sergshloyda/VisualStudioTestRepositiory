using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hello
    {
        public  string HelloString { get; set; }
        public void Print()
        {
            Console.Write(HelloString);
        }
       
    }
    class World
    {
        public string WorldString { get; set; }
        public void Print()
        {
            Console.Write(WorldString);
        }
    }
    class Facade
    {
      
         void Tab()
        {
            Console.Write("  ");
        }
        public void HelloWorld()
        {
            Hello hello = new Hello();
            World world = new World();
            hello.HelloString = "Hello";
            hello.Print();
            world.WorldString = "Мир";
            Tab();
            world.Print();
            
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
