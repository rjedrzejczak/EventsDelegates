using System;

namespace EventsDelegates
{
    public class Multicast
    {
        public delegate void Del();

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
        
    }
}