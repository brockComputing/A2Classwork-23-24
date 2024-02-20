using System;

namespace StatefulVsStateless
{
    internal class Stateful
    {
        static int balance = 0; // uses memory

        static int AddOneStateful()
        {
            balance++;
            return balance;
        }

        static int AddOneStateless(int num)
        {
            num++;
            return num;
        }

        static void Main(string[] args)
        {
            string test = @"hello's";
            test = test.Replace(@"'", @"''");
            Console.WriteLine(test);
            Console.WriteLine(AddOneStateful());
            Console.WriteLine(AddOneStateless(3));
            Console.ReadLine();
        }
    }
}