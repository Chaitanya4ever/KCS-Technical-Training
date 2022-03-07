using System;

namespace Inheritance
{

    
    class Forest
    {

        public string name;

        private void dis()
        {
            Console.WriteLine("There are many living things in Jungle");
        }

    }

    
    class Animals : Forest
    {

        private void getName()
        {
            Console.WriteLine("King of Jungle is " + name);
        }
    }
    class Lion : Animals 
    {
        public int a = 10;
        public void get()
        {
            Console.WriteLine(a);
        }
    
    }

    class Program
    {

        static void Main(string[] args)
        {
            Lion obj = new Lion();
                     
            obj.name = "Lion";
            //obj.dis(); // parent class private function cannot called by child class object

            obj.get();
            //obj.getName();

            Console.ReadLine();
        }

    }
}