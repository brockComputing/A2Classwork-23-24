using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Box
{
    internal class BBox
    {

        static void PrintList(int num)
        {
           // counter++;
            num = num - 1;
            //if (num > 1)
            {
                //Console.WriteLine(counter);
                PrintList(num);
            }
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            PrintList(10);
            Console.WriteLine("finished");
            int x = 99;
            Fred();
            Console.WriteLine(x);
            Console.ReadLine();

        }

        private static void Fred()
        {
            int q = 56;
            Jeff();
            Console.WriteLine(q);
        }

        private static void Jeff()
        {
            Console.WriteLine("hello from jeff");
        }
    }
}
