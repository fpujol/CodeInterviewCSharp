using CodeInterviewConsole.strings;
using System;
using Xunit;

namespace CodeInterviewTests
{

    public class ReverseEachWordGivenStrinsgTest
    {
        /// <summary>
        /// This should test the reverse string
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Welcome to Csharp corner", "emocleW ot prahsC renroc")]
        public void Should_Each_Word_Be_Reversed(string origin, string expected)
        {
            ReverseEachWordGivenString sut = new ReverseEachWordGivenString();
            var result = sut.Run(origin);
            Assert.Equal(expected, result);
        }

    }

}
