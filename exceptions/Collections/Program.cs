using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> myStringList = new List<string>();

            myStringList.Add("C#");
            myStringList.Add("java");
            myStringList.Add("javascript");
            myStringList.Add("python");

            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            if (myStringList.Contains("java"))
            {
                myStringList.Remove("java");
            }

            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Zoo myAwsomeZoo = new Zoo();
            foreach (var animal in myAwsomeZoo.Animals)
            {
                Console.WriteLine($"This is a {animal.Name} and it's a{animal.Gender}");
            }

            Console.WriteLine("__________________________stack");

            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".NET");
            myStack.Push("SQL");

            int count = myStack.Count;

            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(myStack.Peek());
            }


            Console.WriteLine("__________________________queue");

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".NET");
            myQueue.Enqueue("SQL");

            int countQ = myQueue.Count;
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(myQueue.Peek());
            }

            Console.WriteLine("_____________________ Dictionary");
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            dict.Add("Gigi", 30.23m);
            dict.Add("Ion", 23.23m);
            dict.Add("Mos Craciun", 0m);

            foreach (var record in dict)
            {
                Console.WriteLine($"{record.Key}:{record.Value}");
            }

            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();

            List<ILandBound> landAnimals = new List<ILandBound>();

        }
    }
}
