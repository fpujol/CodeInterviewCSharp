using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviewConsole.strings
{
    public class ReverseEachWordGivenString
    {

        /// <summary>
        /// This method should reverse each word given string
        /// ex:
        ///     input: Welcome to Csharp corner, output: emocleW ot prahsC renroc
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public string Run(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);
                    
                    if (i != str.Length - 1)
                        output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }

            return output.ToString();
        }
    }
}
