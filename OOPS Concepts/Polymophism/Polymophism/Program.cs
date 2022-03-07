using System;

class Animal  
{
    public char c = 'a';
    public virtual void animalSound()
    {
        Console.WriteLine(c);
    }
}

class lion : Animal  
{
    public float b = 2.4f;
    public override void animalSound()
    {
        Console.WriteLine(b);
    }
}

class Dog : Animal 
{
    public int a = 10;
    public override void animalSound()
    {
        Console.WriteLine(a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();  
        Animal l = new lion();  
        Animal d = new Dog();  

        a.animalSound();
        l.animalSound();
        d.animalSound();
    }
}