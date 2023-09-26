using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Box
{
    internal class BBox
    {
        static void Main(string[] args)
        {
            Stack <string> stack = new Stack<string>();
            stack.Push("ray");
            stack.Push("zoe");
            stack.Push("jon");
            stack.Push("mik");
            string item = stack.Pop();
            Console.WriteLine(item);
            Console.ReadLine();

        }
    }
}
