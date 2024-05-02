using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_Program
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            int startPos = 0, endPos = 0;
            Console.WriteLine("Enter the word");
            string theWord = Console.ReadLine();
            string vowels = "aeiou";
            endPos = theWord.Length - 1;
            while (startPos < endPos)
            {
                if (vowels.Contains(theWord[startPos].ToString()))
                {
                    // find the vowel
                    bool foundEndVowel = false;
                    do
                    {
                        if (vowels.Contains(theWord[endPos].ToString()))
                        {
                            foundEndVowel = true;
                            break;
                        }
                        endPos--;
                    } while (foundEndVowel == false && startPos < endPos);
                    //swap
                    if (foundEndVowel)
                    {
                        string first = theWord[startPos].ToString();
                        string second = theWord[endPos].ToString();
                        theWord = theWord.Insert(startPos, second);
                        theWord = theWord.Remove(startPos + 1,1);
                        theWord = theWord.Insert(endPos, first);
                        theWord = theWord.Remove(endPos + 1,1);
                        endPos--;
                    }
                }
                startPos++;
            }
            Console.WriteLine(theWord);
            Console.ReadLine();

        }
    }
}
