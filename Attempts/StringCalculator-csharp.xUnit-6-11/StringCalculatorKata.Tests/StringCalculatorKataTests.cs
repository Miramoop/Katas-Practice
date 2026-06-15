using StringCalculatorAttempt6_11;

namespace StringCalculatorKata.Tests;

public class StringCalculatorKataTests
{
    [Fact]
    public void Add_GivenEmptyString_Return0()
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
        Assert.Equal("Negative Numbers Not Allowed: -1,-4", response.Message);
    }

    [Fact]
    public void Add_GivenStringEndingInComma_ThrowEndOfFileFoundError()
    {
        var calculator = new StringCalculator();
        var response = Assert.Throws<Exception>(() => calculator.Add("1,2,3,"));
        Assert.Equal("Number expected but EOF found.",response.Message);
    }
    
    [Fact]
    public void Add_GivenStringEndingInNewLine_ThrowEndOfFileFoundError()
    {
        var calculator = new StringCalculator();
        var response = Assert.Throws<Exception>(() => calculator.Add("1,2,3\n"));
        Assert.Equal("Number expected but EOF found.",response.Message);
    }

    [Fact]
    public void Add_GivenStringWithNewLineSeparator_ReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2");
        Assert.Equal(3,result);
    }
}