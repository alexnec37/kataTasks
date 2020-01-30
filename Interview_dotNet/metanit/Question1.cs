using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public override void Foo()
        {
            Console.Write("Class B");
        }
    }

    //B obj1 = new A();
    //obj1.Foo();
    
    //B obj2 = new B();
    //obj2.Foo(); //Class B

    //A obj3 = new B();
    //obj3.Foo(); //Class B
}
