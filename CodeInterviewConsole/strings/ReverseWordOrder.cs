using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviewConsole.strings
{
    public class ReverseWordOrder
    {

        /// <summary>
        /// This method should reverse the word order
        /// ex:
        ///     input: Welcome to Csharp corner, output: corner Csharp to Welcome
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public string Run(string origin)
        {

            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = origin.Length - 1;
            int End = origin.Length - 1;

            while (Start > 0)
            {
                if (origin[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(origin[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(origin[i]);
            }

            return reverseSentence.ToString();

        }

    }
}
