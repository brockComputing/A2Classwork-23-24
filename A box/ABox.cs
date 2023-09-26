using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_box
{
    internal class ABox
    {
        static int counter =0;
        static void PrintList(int num)
        {
            counter++;
            num = num - 1;
            //if (num > 1)
            {
                Console.WriteLine(counter);
                PrintList(num);
            }
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int abc = 10;
            PrintList(abc);
            Console.WriteLine("fin");
            Console.ReadLine();
        }
    }
}
