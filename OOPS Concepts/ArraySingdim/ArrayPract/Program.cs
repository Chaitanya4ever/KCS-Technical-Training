using System;

namespace ArrayPract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Explicitly Array Declaration & Initializing.

            /* int[] arr = new int[4] { 2, 4, 8, 10 };
            Console.WriteLine("\nInteger Array elements are:" + " " + arr[0] + " " + arr[1] + " " + arr[2]);
            Console.WriteLine("arr has {0} elements", arr.Length);*/

            // Implicitly Array Declaration & Initializing.

            /*var arr = new[] { 2, 4, 8, 10, 12 };
            Console.WriteLine("\nImplicit Array elements are:" + " " + arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4]);
            Console.WriteLine("arr has {0} elements", arr.Length);*/

            //Object Array Declaration & Initializing

            Object[] Obj = new Object[] { true, false, "Chaitanya", 10, 14.2 };
            Console.WriteLine("\nObjects Array elements are:" + " " + Obj[0] + " " + Obj[1] + " " + Obj[2] + " " + Obj[3]);
            Console.WriteLine("Object Array has {0} elements", Obj.Length);
            Console.WriteLine("Object Array type 1 is {0} ", Obj[0].GetType());
            Console.WriteLine("Object Array type 2 is {0} ", Obj[1].GetType());
            Console.WriteLine("Object Array type 3 is {0} ", Obj[2].GetType());
            Console.WriteLine("Object Array type 4 is {0} ", Obj[3].GetType());

            Console.ReadKey();
        }
    }
}
