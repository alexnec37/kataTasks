using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    class Question6
    {
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }
        
        public static void DoSomeThing()
        {
            lock (syncObject)
            {
                Write();
            }
        }
    }
}
