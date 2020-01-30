using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_dotNet.metanit
{
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
    
    //Что будет выведено в следующем случае:
    //var s = new S();
    //using (s)
    //{
    //    Console.WriteLine(s.GetDispose());
    //}
    //Console.WriteLine(s.GetDispose());
}
