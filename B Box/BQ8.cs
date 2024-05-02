using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Box
{
    internal class BQ8
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
                    Console.WriteLine("not correct chars");
                }
                // check if uppercase
                for (int i = 0; i < theString.Length; i++)
                {
                    if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(theString[i].ToString()))
                    {
                        valid = false;
                        Console.WriteLine("not upper case");
                        break;
                    }
                }
                // check for duplicates
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
                // check for ascii codes add 420 to 600
                int totalAscii = 0;
                for (int i = 0; i < theString.Length; i++)
                {
                    totalAscii += theString[i];
                }
                if (totalAscii < 420 || totalAscii > 600)
                {
                    Console.WriteLine("ascii out of range");
                    valid = false;
                }
            } while (valid == false);
            Console.WriteLine("valid string");
            Console.ReadLine();
        }


    }
}
