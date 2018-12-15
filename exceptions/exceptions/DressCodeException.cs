using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions
{
    class DressCodeException : ApplicationException
    {
        string message = "You are not wearing an elf costume and you are under age!";
        public DressCodeException()
        {
            Console.WriteLine(message);
        }
    }
}

