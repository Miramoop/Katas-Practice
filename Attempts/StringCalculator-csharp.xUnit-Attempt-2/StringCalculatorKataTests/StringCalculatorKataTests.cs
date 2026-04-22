using System;
using Xunit;

namespace StringCalculatorKataTests
{
    public class StringCalculatorKataTests
    {
        [Fact]
        public void Add_GivenEmptyString_Returns0()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.Equal(0, result);
        }
        [Fact]
        public void Add_GivenNumber_ReturnNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Add_GivenTwoNumbers_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Add_GivenMultipleNumbers_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,0");
            Assert.Equal(6, result);
        }
        
        [Fact]
        public void Add_GivenNegativeNumbers_ThrowNotAllowedError()
        {
            var calculator = new StringCalculator();
            var response = Assert.Throws<Exception>(() => calculator.Add("-1,-4,0"));
            Assert.Equal("Negative Numbers Not Allowed: -1, -4", response.Message);
        }
    }
}