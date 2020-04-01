using System;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Car d = new Car();
            
            d.OnChange += DOnOnChange;
            d.Speed = 70;
            Console.WriteLine("Hello World!");
        }

        private static void DOnOnChange()
        {
            Console.WriteLine("EVENT >= 60");
        }
    }
}