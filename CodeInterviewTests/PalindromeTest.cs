using CodeInterviewConsole.strings;
using System;
using Xunit;

namespace CodeInterviewTests
{

    public class PalindromeTest
    {
        /// <summary>
        /// This should test the reverse string
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="source"></param>
        [Theory]
        [InlineData("madam", "Palindrome")]
        [InlineData("step on no pets", "Palindrome")]
        [InlineData("book", "Not Palindrome")]
        [InlineData("1221", "Palindrome")]
        [InlineData("dad", "Palindrome")]
        public void Should_A_String_Be_Palindrome_Or_Not(string origin, string source)
        {
            Palindrome sut = new Palindrome();
            var result = sut.Run(origin);
            Assert.Equal(result, source);
        }

    }

}
