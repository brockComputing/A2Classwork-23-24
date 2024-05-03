using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Create_a_Program
{
    internal class Q7Prog
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a number ");
            int numberInHarshad = Convert.ToInt32(Console.ReadLine());
            int currentNum = 1;
            do
            {
                if (IsHarsh(currentNum))
                {
                    count++;

                }
                currentNum++;
            } while (count != numberInHarshad);
            currentNum--;
            Console.WriteLine(currentNum);
            Console.ReadLine();

        }

        private static bool IsHarsh(int currentNum)
        {
            string strNum = currentNum.ToString() ;
            int total = 0;
            foreach (var item in strNum)
            {
                total += Convert.ToInt32(item.ToString()) ;
            }
            if (currentNum % total == 0)
            {
                return true;
            }
            return false;
        }
    }
}
