using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calcultor1
    {
        public void All()
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number ");
            int b = Convert.ToInt32(Console.ReadLine());
            

            int addition = a + b;
            int sub = a - b;
            int mul = a * b;
            Console.WriteLine(addition);
            Console.ReadLine();
            Console.WriteLine(sub);
            Console.ReadLine();
            Console.WriteLine(mul);
            Console.ReadLine();

        }
    }
}
