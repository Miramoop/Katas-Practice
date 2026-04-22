namespace StringCalculatorKataTests;

public class StringCalculatorKataTests
{
    private StringCalculator = _calculator = new StringCalculator();
    
    [Fact]
    public void Add_GivenEmptyString_Returns0()
    {
        var result = _calculator.Add("");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Add_GivenOne_ReturnOne()
    {
        var result = _calculator.Add("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void Add_GivenTwoNumbersSeparatedByComma_ReturnSum()
    {
        var result = _calculator.Add("1,2");
        Assert.Equal(3, result);
    }

    [Fact]
    public void Add_GivenThreeNumbersSeparatedByComma_ReturnSum()
    {
        var result = _calculator.Add("1,2,3");
        Assert.Equal(6, result);
    }

    [Fact]
    public void Add_GivenThreeNumbersSeparatedByCommaOrNewLine_ReturnSum()
    {
        var result = _calculator.Add("1,2\n3");
        Assert.Equal(6, result);
    }
}