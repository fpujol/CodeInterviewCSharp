using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviewConsole.strings
{
    public class ReverseString
    {

        /// <summary>
        /// This method should reverse the string
        /// ex:
        ///     input: hello, output: olleh
        ///     input: hello world, output: dlrow olleh
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public string Run(string origin)
        {

            char[] charArray = origin.ToCharArray();

            for (int i = 0,j=origin.Length-1; i < j; i++,j--)
            {
                charArray[i] = origin[j];
                charArray[j] = origin[i];
            }

            return new string(charArray);

        }
    }
}
