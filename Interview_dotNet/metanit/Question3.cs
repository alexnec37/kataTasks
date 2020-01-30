using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    class Question3
    {
        public static void DoSomeThing()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action();
            }
        }
             
    }
}
