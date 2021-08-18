using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviewConsole.strings
{
    public class Palindrome
    {

        /// <summary>
        /// This method should reverse the string
        /// ex:
        ///     input: madam, output: Palindrome
        ///     input: step on no pets, output: Palindrome
        ///     input: book, output: Not Palindrome
        ///     input: 1221, output: Palindrome
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public string Run(string origin)
        {

            bool arePalindrome = true;
            for (int i = 0, j=origin.Length-1; i < j; i++, j--)
            {
                if (origin[i] != origin[j])
                {
                    arePalindrome = false;
                    break;
                }
            }

            return (arePalindrome) ? "Palindrome" : "Not Palindrome";

        }
    }
}
