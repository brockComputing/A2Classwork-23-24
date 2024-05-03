//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Create_a_Program
//{
//    internal class Q5Prog
//    {
//        static void Main(string[] args)
//        {
//            int[] numArray = new int[10];
//            Console.WriteLine("enter how many digits you would like to enter");
//            int numDigits = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < numDigits; i++)
//            {
//                int number = Convert.ToInt32(Console.ReadLine());
//                numArray[number] += 1;
//            }
//            int highest = numArray[0];
//            int posOfHighest = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                if (numArray[i] > highest)
//                {
//                    highest = numArray[i];
//                    posOfHighest = i;
//                }
//            }
//            // check if multimodal
//            int count = 0;
//            for (int i = 0; i < 10; i++)
//            {
//                if (numArray[i] == highest)
//                {
//                    count++;
//                }
//            }
//            if (count > 1)
//            {
//                Console.WriteLine("multimodal");
//            }
//            else
//            {
//                Console.WriteLine($"The most freqent number was {posOfHighest} it occured {numArray[posOfHighest]} times");
//            }
//            Console.ReadLine();
//        }
//    }
//}
