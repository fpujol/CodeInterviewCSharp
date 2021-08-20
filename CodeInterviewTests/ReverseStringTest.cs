using CodeInterviewConsole.strings;
using System;
using Xunit;

namespace CodeInterviewTests
{

    public class ReverseStringTest
    {
        /// <summary>
        /// This should test the reverse string
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Hello", "olleH")]
        [InlineData("hello world", "dlrow olleh")]
        public void A_String_Should_Be_Reversed(string origin, string expected)
        {
            ReverseString sut = new ReverseString();
            var result = sut.Run(origin);
            Assert.Equal(expected, result);
        }

    }

}
