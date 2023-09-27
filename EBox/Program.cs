using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBox
{
    internal class Program
    {
        static int[] items = new int[] { 0, 4, 5, 8, 11, 15, 19, 21, 28, 33 };
        static int counter = 0;
        static void ProcA(int number, int entry)
        {
            //Console.WriteLine("entry -" + entry);
            if (number != items[entry])
            {
                ProcA(number, entry + 1);
            }
            else
            {
                Console.WriteLine("output " + entry);
            }
        }
       
        static void Main(string[] args)
        {
            ProcA(11, 1);
            Console.ReadLine();
        }
        private static void Jeff()
        {
            int y = 66;
            Bob();
            Console.WriteLine(y);  
        }
        private static void Bob()
        {
            Console.WriteLine("hello from bob");
        }
    }
}
