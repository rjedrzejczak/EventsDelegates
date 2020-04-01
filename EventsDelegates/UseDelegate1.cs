using System;

namespace EventsDelegates
{
    public class UseDelegate1
    {
        public delegate int Calculate(int x, int y);

        public UseDelegate1()
        {
            Calculate calc = (x, y) => x + y;
//            Action<int, int> calc = (x, y) => { 
//                Console.WriteLine(x + y); 
//            };
            //I dont know why this is not working like in Multicast. It only run second delegate
//            calc += (x, y) =>
//            {
//                Console.WriteLine("Adding numbers");
//                return x * y;
//            };

            Console.WriteLine(calc(5, 5));
//            calc(5, 5);
        }
    }
}