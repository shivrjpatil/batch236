using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        
        
        public void Add(int A,int B)
        {
            
            int Result= A + B;
            Console.WriteLine("addition of two numbers:"+Result);
            Console.ReadLine();

        }
        public void Sub(int A,int B)
        {
           int Result = A - B;
            Console.WriteLine("substraction of two numbeer:" + Result);
            Console.ReadLine();
        }
        public void Mul(int A,int B)
        {
            int Result= B * A;
            Console.WriteLine("multipliction of two numbers:" + Result);
            Console.ReadLine();


        }
        public void Div(int A,int B)
        {
            int Result= A / B;
            Console.WriteLine("division of two numbers:"  + Result);
            Console.ReadLine();
        }
    }
}
