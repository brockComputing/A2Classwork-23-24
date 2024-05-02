using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBox
{
    internal class EQ8Prog
    {
        static void Main(string[] args)
        {
            bool valid;
            do
            {
                valid = true;
                Console.WriteLine("Enter the string");
                string theString = Console.ReadLine();
                if (theString.Length < 5 || theString.Length > 7)
                {
                    Console.WriteLine("wrong length");
                    valid = false;
                }
                // check upper only
                if (theString.ToUpper() != theString)
                {
                    Console.WriteLine("not upper");
                    valid = false;
                }
                // duplicates
                int countofLetter = 0;
                for (int startPos = 0; startPos < theString.Length; startPos++)
                {
                    countofLetter = 0;
                    string currentletter = theString[startPos].ToString();
                    for (int i = 0; i < theString.Length; i++)
                    {
                        if (theString[i].ToString() == currentletter)
                        {
                            countofLetter++;
                        }
                    }
                    if (countofLetter > 1)
                    {
                        Console.WriteLine("duplicates");
                        valid = false;
                        break;
                    }
                }
                // add up the ascii codes
                int totalAscii = 0;
                for (int i = 0; i < theString.Length; i++)
                {
                    int code = theString[i];
                    totalAscii = totalAscii + Convert.ToInt32(theString[i]);
                }
                if (totalAscii < 420 || totalAscii > 600)
                {
                    valid = false;
                    Console.WriteLine("ASCII is out of range");
                }
            } while (valid == false) ;
            Console.WriteLine("its valid");
            Console.ReadLine();
        }
    }
}
