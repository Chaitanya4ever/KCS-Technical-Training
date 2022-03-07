using System;


namespace OOPS
{


     public class Encapsulation
    {
        private int pr; 
        internal int i; 
        protected int prot;
        public int pu;
        protected internal int pi;
        private protected int pp;

        public Encapsulation()
        {
            pr = 100;
        }

        public void AccessibleDemoFun()
        {
            pr = 10; 
            i = 20; 
            prot = 30;
            pi = 40; 
            pp = 50;
        }
    }

    class EncapsulationAndInheritanceDemo : Encapsulation
    {
        public void AccessibleDemoFunOfDirectChildClass()
        {
            i = 20;
            prot = 30; 
            pi = 40;
            pp = 60;
        }
    }

    class EncapsulationAndInheritanceDemoSubChild : EncapsulationAndInheritanceDemo
    {
        public void AccessibleDemoFunOfSubChildClass()
        {
            
            //pr = 10; 
            prot = 20; 
            pi = 30; 
            i = 20; 
            pp = 60; 
        }
    }

     class Polymorphism_FunctionOverloading
    {
        public void demo()
        {
            Console.WriteLine("1st demo function in Polymorphism_FunctionOverloading class - no return type, no parameter.");
        }
        public void demo(int a)
        {
            Console.WriteLine("2nd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter");
        }
        public void demo(int a, char b)
        {
            Console.WriteLine("3rd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter + 1 character parameter.");
        }
    }

     class Base_Cls
    {
        public virtual void DemoFunction()
        {
            Console.WriteLine("Base_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Base_Cls Saying Hello second time!");
        }
    }
    class Derived_Cls : Base_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Cls Saying Hello second time!");
        }

    }
    class Derived_Sub_Cls : Derived_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Sub_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Sub_Cls Saying Hello second time!");
        }
    }

    
    abstract class Parent_AbsCls
    {
        public void DemoParentAbsNormal_Fun()
        {
            Console.WriteLine("Normal Method of Normal Class Named - Parent_AbsCls is called.");
        }
        public abstract void DemoParentAbsAbstract_Fun();
    }

    abstract class Abstract_CLS : Parent_AbsCls
    {
        public abstract void DemoABS_Fun();
        public void DemoNormal_Fun()
        {
            Console.WriteLine("Normal Method of Abstract Class Named - Abstract_CLS is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN Abstract_CLS.");
        }
    }

    class ChildCLS_AbsDemo : Abstract_CLS
    {
        public override void DemoABS_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Abstract class is call.");
        }
        public void DemoChildNormal_Fun()
        {
            Console.WriteLine("Normal Method of Child Class Named - ChildCLS_AbsDemo is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN ChildCLS_AbsDemo.");
        }
    }

    
    interface IParent
    {
        void IAbsDemo();
    }
    interface IParent2
    {
        void IAbsDemo();
    }
    class InterfaceDemo_CLS : IParent, IParent2
    {
        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS2 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent1 Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS3 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }


    static class DemoStaticCLS
    {
        public static int a;
    }

    class DemoStaticCLSWithNormal
    {
        public int a1;
        public static int b;
    }

    public class NormalSealedCLSDemo
    {
        public int a2 = 300;
    }
    sealed class DemoSealedCLS : NormalSealedCLSDemo
    {
        public int InheritDemo;
    }

    public partial class DemoParCLS
    {
        public int p1;
    }

    public partial class DemoParCLS
    {
        public int p2;
    }

    public class ChildCLS : DemoParCLS
    {
        public int child;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation & Ingeritance in Class.
            Encapsulation En = new Encapsulation();
            En.i = 100; // Internal can be access in same name space at anywhere.
            En.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            En.pu = 102;

            //By Default EncapsulationAndInheritanceDemo is OOPS namespace class.
            EncapsulationAndInheritanceDemo EnI = new EncapsulationAndInheritanceDemo();
            EnI.i = 100; // Internal can be access in same name space at anywhere.
            EnI.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            EnI.pu = 102; // Public can be access anywhere in project.

            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu);

            //By Default EncapsulationAndInheritanceDemo is OOPS namespace class.
            EncapsulationAndInheritanceDemoSubChild EnIDSC = new EncapsulationAndInheritanceDemoSubChild();
            EnIDSC.i = 100; // Internal can be access in same name space at anywhere.
            EnIDSC.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            EnIDSC.pu = 102; // Public can be access anywhere in project.

            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i + "-" + EnIDSC.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + EnIDSC.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + EnIDSC.pu);

            //We can call EncapsulationAndInheritanceDemo from OOPS_Demo_Inheritance namespace class ny using OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemo
            OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace OOPSD_EnI = new OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace();
            OOPSD_EnI.i = 100; // Internal can be access in same name space at anywhere.
            OOPSD_EnI.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            OOPSD_EnI.pu = 102; // Public can be access anywhere in project.
            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i + "-" + OOPSD_EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + OOPSD_EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + OOPSD_EnI.pu);


            // Function Overloading - Polymorphism.
            Polymorphism_FunctionOverloading PolyFunOverLoading = new Polymorphism_FunctionOverloading();
            PolyFunOverLoading.demo(); // demo function with no arguments.
            PolyFunOverLoading.demo(1); // demo function with one integer argument.
            PolyFunOverLoading.demo(1, 'A'); // demo function with one integer argument + one character argument.

            // Function Overriding - Polymorphism.
            Base_Cls B_CLS = new Base_Cls();
            B_CLS.DemoFunction(); // Base Class function named DemoFunction() called by its own object.
            B_CLS.DemoFunction2(); // Base Class function named DemoFunction2() called by its own object.

            Derived_Cls D_CLS = new Derived_Cls();
            D_CLS.DemoFunction(); // Derived Class function named DemoFunction() called by its own object.
            D_CLS.DemoFunction2(); // Derived Class function named DemoFunction2() called by its own object.

            Derived_Sub_Cls DS_CLS = new Derived_Sub_Cls();
            DS_CLS.DemoFunction(); // Derived Class function named DemoFunction() called by its own object.
            DS_CLS.DemoFunction2(); // Derived Class function named DemoFunction2() called by its own object.


            //*** Abstraction ***
            ChildCLS_AbsDemo CCLS_AbsDemo = new ChildCLS_AbsDemo();
            CCLS_AbsDemo.DemoNormal_Fun();
            CCLS_AbsDemo.DemoABS_Fun();
            CCLS_AbsDemo.DemoChildNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsAbstract_Fun();

            Abstract_CLS AbCLS = new ChildCLS_AbsDemo(); // Abstract class have a reference variable but no instance - abstract class reference variable can assigned by its child class instance.
            AbCLS.DemoABS_Fun();
            AbCLS.DemoNormal_Fun();
            AbCLS.DemoParentAbsNormal_Fun();
            AbCLS.DemoParentAbsAbstract_Fun();


            IParent ICls = new InterfaceDemo_CLS();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS2();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS3();
            ICls.IAbsDemo();


            // In static class no need to create an instance.
            DemoStaticCLS.a = 10;


            DemoStaticCLSWithNormal DSWN = new DemoStaticCLSWithNormal();
            DSWN.a1 = 100;

            // In normal class no need to create an instance for the static field.
            DemoStaticCLSWithNormal.b = 200;

            DemoParCLS DPC = new DemoParCLS();
            DPC.p1 = 300;
            DPC.p2 = 400;

            ChildCLS CCLS = new ChildCLS();
            CCLS.p1 = 1000;
            CCLS.p2 = 1000;

            Console.ReadKey();
        }
    }
}


namespace OOPS_Demo_Inheritance
{
    class EncapsulationAndInheritanceDemoInDifferentNameSpace : OOPS.Encapsulation
    {
        // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
        public void AccessibleDemoFunOfDirectChildClassInDifferentNameSpace()
        {
            //pr = 10; 
            prot = 20; 
            pi = 30; 
            i = 20; 
            pp = 60;
        }
    }

}

