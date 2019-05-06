using System;

namespace Polymorphism2
{
    //Explain using Virtual and Override keywords and how they affect output.

    class A
    {
        public virtual void display() { Console.WriteLine("I am A"); }
    }

    class B : A //if child has override PARENT MUST HAVE virtual for override to take place
    {
        public override void display() { Console.WriteLine("I am B"); }
    }

    class Test2
    {
        static void Main(string[] args)
        {
            A a;
            B b;

            a =new A();
            b = new B();

            a.display();
            b.display();

            a = new B();
            a.display();

            Console.ReadLine();
        }
    }
}
