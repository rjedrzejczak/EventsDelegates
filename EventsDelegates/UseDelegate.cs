using System;
using System.Runtime.ConstrainedExecution;

namespace EventsDelegates
{
    public class UseDelegate
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public UseDelegate()
        {
            Calculate calc = Add;
            
            Console.WriteLine(calc(3,4));

            calc = Multiply;
            
            Console.WriteLine(calc(3,4));
        }
    }
}