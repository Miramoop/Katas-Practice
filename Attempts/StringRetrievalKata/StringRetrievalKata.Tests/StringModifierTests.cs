namespace StringRetrievalKata.Tests;

public class StringModifierTests
{
    [Fact]
    public void ReverseString_GivenEmptyString_ReturnNothing()
    {
        var stringModifier = new StringModifier();
        var result = stringModifier.ReverseString("");
        Assert.Equal(0,result);
    }
    [Fact]
    public void ReverseString_GivenSingleItemString_ReturnSingleItem()
    {
        var stringModifier = new StringModifier();
        var result = stringModifier.ReverseString("a");
        Assert.Equal(1,result);
    }
    [Fact]
    public void ReverseString_GivenTwoItemString_ReturnReversedString()
    {
        var stringModifier = new StringModifier();
        var result = stringModifier.ReverseString("abe");
        Assert.Equal(2,result);
    }
}