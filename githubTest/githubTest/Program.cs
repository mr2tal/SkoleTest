using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        static void MethodA()
        {
            Console.WriteLine("er du der metode B?");
            MethodB();
        }

        static void MethodB()
        {
            Console.WriteLine("Ja det er jeg metode A!");
        }
    }
}
