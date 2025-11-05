using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        internal class Myclass
        {
            internal void Add()
            {
                int a = 10;
                int b = 20;
                int c = a + b;
                Console.WriteLine("Addition is: " + c);
            }
            internal void Display()
            {
                Console.WriteLine("Welcome");
            }
        }
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Add();
            Console.WriteLine("Hello World!");
            obj.Add();
            obj.Display();
            Console.WriteLine("Hiii");
            obj.Add();
            Console.ReadLine();
        }
    }
}
