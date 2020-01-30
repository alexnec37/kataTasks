using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    class Question4
    {
        public static void DoSomeThing()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine((short)obj);
        }
    }
}
