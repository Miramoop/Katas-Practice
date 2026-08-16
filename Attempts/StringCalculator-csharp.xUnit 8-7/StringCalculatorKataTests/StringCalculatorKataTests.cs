using StringCalculatorKata;

namespace StringCalculatorKataTests;

public class StringCalculatorKataTests
{
    // [Fact]
    // public void AddNumbers_GivenEmptyString_Returns0()
    // {
    //     var calculator = new StringCalculator();
    //     var result = calculator.Add("");
    //     Assert.Equal(0,result);
    // }
    // [Fact]
    // public void AddNumbers_GivenSingleNumber_ReturnsSingleNumber()
    // {
    //     var calculator = new StringCalculator();
    //     var result = calculator.Add("1");
    //     Assert.Equal(1,result);
    // }
    // [Fact]
    // public void AddNumbers_GivenTwoDigitNumber_ReturnNumber()
    // {
    //     var calculator = new StringCalculator();
    //     var result = calculator.Add("22");
    //     Assert.Equal(22,result);
    // }
    // [Fact]
    // public void AddNumbers_GivenTwoNumbers_ReturnSum()
    // {
    //     var calculator = new StringCalculator();
    //     var result = calculator.Add("2,3");
    //     Assert.Equal(5,result);
    // }
    // [Fact]
    // public void AddNumbers_GivenMultipleNumbers_ReturnSum()
    // {
    //     var calculator = new StringCalculator();
    //     var result = calculator.Add("2,3,2");
    //     Assert.Equal(7,result);
    // }
    // [Fact]
    // public void AddNumbers_GivenNegativeNumbers_ReturnNegativeNumbersNotAllowed()
    // {
    //     var calculator = new StringCalculator();
    //     var response = Assert.Throws<Exception>(() => calculator.Add("-1,-4"));
    //     Assert.Equal("Negative Numbers not allowed: -1,-4",response.Message);
    // }
    // [Fact]
    // public void Add_GivenStringEndingInSeparator_ReturnEOFFound()
    // {
    //     var calculator = new StringCalculator();
    //     var response = Assert.Throws<Exception>(() => calculator.Add("1,2"));
    //     Assert.Equal("Number expected but EOF found",response.Message);
    // }
    // [Fact]
    // public void Add_GivenMultipleNumbersSeparatedByNewLine_ReturnSum()
    // {
    //     var calculator = new StringCalculator();
    //     var response = Assert.Throws<Exception>(() => calculator.Add("2\n3\n2"));
    //     Assert.Equal(7,result);
    // }
    [Fact]
    public void MSG_PassError_ReturnErrorMessage()
    {
        //var msg = new MSG();
        var calculator = new StringCalculator();
        var msg = calculator.Add("-1,-4");
        Assert.Equal("Negative Numbers not allowed: -1,-4",msg.Message);
        Assert.Equal(0,msg.Value);
    }
}