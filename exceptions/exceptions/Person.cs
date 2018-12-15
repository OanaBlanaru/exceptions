using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("can't be negative", "Age");
                }

                if (value == 2 || value >80)
                {
                    throw new DressCodeException();
                }

                this.age = value;

            }
        }

        public Person(int age)
        {
            this.Age = age;
        }
    }
}
