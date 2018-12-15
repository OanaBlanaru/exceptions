using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int b = 100;
            //    int a = b / 0;

            //    Console.WriteLine(a);
            //}

            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine("Oops, something happened");
            //    Console.WriteLine(exception.Message);
            //    Console.WriteLine(exception.StackTrace);
            //}

            try
            {
                Person x = new Person(15);
                Person t = new Person(-1);
               
                Person y = new Person(80);
                Person z = new Person(81);
            }
            catch (ArgumentException e)
            {
                //Console.WriteLine(e);
                
                Console.WriteLine(e.Message + e.GetType());
                //throw;
                //Person c = new Person(2);
            }

            catch (DressCodeException ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
            }

        }
    }
}
