using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string capOfCoffee = "Tea";
            string capOfTea = "Coffee";
            string cap;

            Console.WriteLine($"Чашка с кофе {capOfCoffee}, Чашка чая {capOfTea}");

            cap = capOfCoffee;
            capOfCoffee = capOfTea;
            capOfTea = cap;

            Console.WriteLine($"Чашка с кофе {capOfCoffee}, Чашка чая {capOfTea}");
            Console.ReadKey();
        }
    }
}
