using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Classwork_23_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Jon");
            stack.Push("dave");
            stack.Push("zoe");
            string item = stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(item);
            Console.WriteLine("Hello");
            Afunction();
            Console.WriteLine("Hi");
            Console.ReadLine();
        }

        private static void Afunction()
        {
            Console.WriteLine("Hello from a function");
            int y = 34;
            AnotherFunction();
            Console.WriteLine("last line in Afunction");
        }

        private static void AnotherFunction()
        {
            Console.WriteLine("hello from another fucntion");
        }
    }
}
