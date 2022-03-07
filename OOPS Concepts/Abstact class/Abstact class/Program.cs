using System;

namespace Abstact_class
{
    abstract class abscls
    {
        
        public abstract void fun();
        
        public void absclsfun()
        {
            Console.WriteLine("This is abstract class function.");
        }
    }

    
    class intnum : abscls
    {
        public int a = 10;
        public override void fun()
        {
            Console.WriteLine("This is int class inherit by abstract class."+a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            intnum obj = new intnum(); 
            obj.absclsfun();  
            obj.fun();  
        }
    }
}
