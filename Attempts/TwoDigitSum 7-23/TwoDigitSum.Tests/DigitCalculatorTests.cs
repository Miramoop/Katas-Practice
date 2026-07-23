namespace TwoDigitSum.Tests;

public class DigitCalculatorTests
{
    [Fact]
    public void Add_InputTwoDigitInteger_ReturnInteger()
    {
        var digitCalculator = new DigitCalculator();
        digitCalculator.Add(12);
        Assert.Equal(12,digitCalculator.InputtedInt);
    }
    
    [Fact]
    public void Add_InputTwoDigitInteger_ReturnTensInteger()
    {
        var digitCalculator = new DigitCalculator();
        digitCalculator.Add(12);
        Assert.Equal(1,digitCalculator.TensPlace);
    }
    
    [Fact]
    public void Add_InputTwoDigitInteger_ReturnOnesInteger()
    {
        var digitCalculator = new DigitCalculator();
        digitCalculator.Add(12);
        Assert.Equal(2,digitCalculator.OnesPlace);
    }
    
    [Fact]
    public void Add_InputTwoDigitInteger_ReturnSumOfDigits()
    {
        var digitCalculator = new DigitCalculator();
        digitCalculator.Add(29);
        Assert.Equal(11,digitCalculator.DigitsSum);
    }
}