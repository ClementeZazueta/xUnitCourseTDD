using ConsoleApp1;
using System;
using Xunit;

namespace TestDrivenDevelopment
{
    public class PasswordTests
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = GenerateStringWithDefaultUpperChar(8);

            var validationResult = testTarget.Validate(password);

            Assert.True(validationResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = GenerateStringWithDefaultUpperChar(7);

            var validationResult = testTarget.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = GenerateStringWithDefaultUpperChar(8).ToLower();

            var validationResult = testTarget.Validate(password);

            Assert.False(validationResult);
        }

        [Fact]
        public void Validate_GivenUpperCase_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = GenerateStringWithDefaultUpperChar(8);

            var validationResult = testTarget.Validate(password);

            Assert.True(validationResult);
        }

        private string GenerateStringWithDefaultUpperChar(int length)
        {
            string result = "A";

            for (int i = 0; i < length - 1; i++)
            {
                result += "a";
            }

            return result;
        }
    }
}
