using CodeInterviewConsole.strings;
using System;
using Xunit;

namespace CodeInterviewTests
{

    public class ReverseWordOrderTest
    {
        /// <summary>
        /// This should test the reverse string
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Welcome to Csharp corner", "corner Csharp to Welcome")]
        public void Should_Word_Order_Be_Reversed(string origin, string expected)
        {
            ReverseWordOrder sut = new ReverseWordOrder();
            var result = sut.Run(origin);
            Assert.Equal(expected, result);
        }

    }

}
