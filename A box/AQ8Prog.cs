//using System;

//namespace Q8AGroup
//{
//    internal class Q8A
//    {

//        static void Main(string[] args)
//        {
//            bool valid;

//            do
//            {
//                Console.WriteLine("enter a string");
//                string theString = Console.ReadLine();
//                valid = true;
//                if (theString.Length < 5 || theString.Length > 7)
//                {
//                    valid = false;
//                    Console.WriteLine("not correct number of  chars");
//                }
//                check if uppercase
//                string copyOF = theString;
//                if (copyOF.ToUpper() != theString)
//                {
//                    valid = false;
//                    Console.WriteLine("not upper case");
//                }
//                duplicates
//                for (int pos = 0; pos < theString.Length; pos++)
//                {
//                    int count = 0;
//                    string currentLetter = theString[pos].ToString();
//                    for (int i = 0; i < theString.Length; i++)
//                    {
//                        if (currentLetter == theString[i].ToString())
//                        {
//                            count++;
//                        }
//                    }
//                    if (count > 1)
//                    {
//                        Console.WriteLine("duplicates");
//                        valid = false;
//                        break;
//                    }
//                }
//                ascii codes
//                int asciiTotal = 0;
//                for (int i = 0; i < theString.Length; i++)
//                {
//                    asciiTotal = asciiTotal + theString[i];
//                }
//                if (asciiTotal < 420 || asciiTotal > 600)
//                {
//                    Console.WriteLine("Ascii not in range");
//                    valid = false;
//                }
//            } while (valid == false);
//            Console.WriteLine("valid string");
//            Console.ReadLine();
//            Console.ReadLine();
//        }
//    }
//}