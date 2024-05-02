using System;

namespace Q8AGroup
{
    internal class Q8A
    {
        
        static void Main(string[] args)
        {
            bool valid;

            do
            {
                Console.WriteLine("enter a string");
                string theString = Console.ReadLine();
                valid = true;
                if (theString.Length < 5 || theString.Length > 7)
                {
                    valid = false;
                    Console.WriteLine("not correct number of  chars");
                }
                // check if uppercase
                string copyOF = theString;
                if (copyOF.ToUpper() != theString)
                {
                    valid = false;
                    Console.WriteLine();
                }

            } while (valid == false);
            Console.WriteLine("valid string");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}