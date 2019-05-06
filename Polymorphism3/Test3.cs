using System;

namespace Polymorphism3
{
    class A
    {
        public void display() { Console.WriteLine("I am A"); }
    }

    class B : A
    {
        public virtual void display() { Console.WriteLine("I am B"); }
    }

    class C : B
    {
        public new void display() {Console.WriteLine("I am C"); }
    }

    class Test3
    {
        static void Main(string[] args)
        {
            
            B b;
            C c;

            
            b = new B();
            b.display();

            b = new C();    
            b.display();    

            Console.ReadLine();
        }
    }
}
