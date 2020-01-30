using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interview_dotNet.metanit
{
    class Question13
    {
        public static void DoSomeThing()
        {
            object sync = new object();
            var thread = new Thread(() =>
            {
                try
                {
                    Work();
                }
                finally
                {
                    lock (sync)
                    {
                        Monitor.PulseAll(sync);
                    }
                }
            });

            thread.Start();
            lock (sync)
            {
                Monitor.Wait(sync);
            }

            Console.WriteLine("test");
        }

        private static void Work()
        {
            Thread.Sleep(1000);
        }
    }
    
}
