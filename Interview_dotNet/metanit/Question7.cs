using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    public class A7
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class B7 : A7
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class C7 : B7
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }

    class Question7
    {
        public static void DoSomeThing()
        {
            var c = new C7();
            A7 a = c;

            a.Print2();
            a.Print1();
            c.Print2();
        }
    }
}
