using System;

namespace UnderstandingPolymorphism
{
    class A
    {
        public void display() { Console.WriteLine("I am A");}
    }

    class B : A
    {
        public void display() { Console.WriteLine("I am B");}
    }

    class Test
    {
        static void Main(string[] args)
        {
            A a;
            B b;

            a = new A();
            b = new B();
            a.display();    
            b.display();

            a = new B();    //where it gets confusing... Doesn't it Hide the Method?
            a.display();    // output: I am A
            
            Console.ReadLine();
        }
    }
}
