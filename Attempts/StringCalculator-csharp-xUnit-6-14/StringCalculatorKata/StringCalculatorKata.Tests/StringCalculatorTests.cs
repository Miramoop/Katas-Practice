namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void Add_GivenEmptyString_Return0()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("");
        Assert.Equal(0,result);
    }

    [Fact]
    public void Add_GivenSingleNumber_ReturnNumber()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");
        Assert.Equal(1,result);
    }

    [Fact]
    public void Add_GivenTwoNumbersSeparatedByComma_ReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2");
        Assert.Equal(3,result);
    }

    [Fact]
    public void Add_GivenThreeNumbersSeparatedByComma__ReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2,3");
        Assert.Equal(6,result);
    }

    [Fact]
    public void Add_GivenNegativeNumbers_ReturnNegativeNumbersNotAllowed()
    {
        var calculator = new StringCalculator();
        var response = Assert.Throws<Exception>(() => calculator.Add("-1,-4"));
        Assert.Equal("Negative Numbers Not Allowed: -1,-4", response.Message);
    }
    
    [Fact]
    public void Add_GivenStringEndingInSeparator_ReturnEOFFound()
    {
        var calculator = new StringCalculator();
        var response = Assert.Throws<Exception>(() => calculator.Add("1,2,"));
        Assert.Equal("Number expected but EOF found.", response.Message);
    }

    [Fact]
    public void Add_GivenTwoNumbersSeparatedByNewLine_ReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2");
        Assert.Equal(3,result);
    }

    [Fact]
    public void Add_GivenThreeNumbersSeparatedByCommaAndNewLine_ReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2\n3");
        Assert.Equal(6,result);
    }

    [Fact]
    public void Add_GivenStringContainingWrongFormat_ReturnFormatException()
    {
        var calculator = new StringCalculator();
        Assert.Throws<FormatException>(() => calculator.Add("1,\n2"));
    }
}