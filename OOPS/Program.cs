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
            internal int x;
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
                Console.WriteLine(x);
            }
            internal void sum(int a, int b)
            {
                int c = a + b;
                Console.WriteLine("sum is: " + c);
            }
        }
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Add();
            Console.WriteLine("Hello World!");
            obj.Add();
            Console.WriteLine("Hiii");
            obj.Add();
            obj.x = 100;
            obj.Display();
            obj.sum(100, 200);
            Console.ReadLine();
        }
    }
}
