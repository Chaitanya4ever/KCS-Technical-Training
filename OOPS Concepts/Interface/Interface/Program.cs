using System;

namespace Interface
{

    interface finterface
    {
        void fMethod();
    }

    interface sinterface
    {
        void sMethod(); 
    }

    
    class DemoClass : finterface, sinterface
    {
        public void fMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void sMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass obj = new DemoClass();
            obj.fMethod();
            obj.sMethod();
        }
    }
}
