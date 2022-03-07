using System;

namespace OOPS_Pract1
{
    public class clsobjdemo
    {
        public int a;
    }
    public class objclspract
    {
        static void Main(string[] args)
        {
            clsobjdemo p = new clsobjdemo();
             p.a = 20;
            Console.WriteLine("Value of a is" + p.a);


        }
    }
}
