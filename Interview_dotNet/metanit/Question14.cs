using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interview_dotNet.metanit
{
    class MyCustomException : DivideByZeroException
    {

    }
    class Question14
    {
        public static void DoSomeThing()
        {
            try
            {
                Calc();
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch MyCustomException");
                throw;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Catch Exception");
            }
            Console.ReadLine();
        }
        private static void Calc()
        {
            int result = 0;
            var x = 5;
            int y = 0;
            try
            {
                result = x / y;
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch DivideByZeroException");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch Exception");
            }
            finally
            {
                throw new MyCustomException();
            }
        }
    }
    
}
