using FizzBuzz_csharp.xUnit;

namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void FizzBuzz_InputOne_ReturnOne()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(1);
        Assert.Equal("1",result);
    }

    [Fact]
    public void FizzBuzz_InputTwo_ReturnTwo()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(2);
        Assert.Equal("2",result);
    }

    [Fact]
    public void FizzBuzz_InputTwentyTwo_ReturnTwentyTwo()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(22);
        Assert.Equal("22", result);
    }

    [Fact]
    public void FizzBuzz_InputThree_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(3);
        Assert.Equal("Fizz",result);
    }

    [Fact]
    public void FizzBuzz_InputSix_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(6);
        Assert.Equal("Fizz",result);
    }

    [Fact]
    public void FizzBuzz_InputFive_ReturnBuzz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(5);
        Assert.Equal("Buzz",result);
    }

    [Fact]
    public void FizzBuzz_InputTen_ReturnBuzz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(10);
        Assert.Equal("Buzz",result);
    }

    [Fact]
    public void FizzBuzz_InputFifteen_ReturnFizzBuzz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(15);
        Assert.Equal("FizzBuzz",result);
    }

    [Fact]
    public void FizzBuzz_InputThirty_ReturnFizzBuzz()
    {
        var fizzBuzz = new FizzBuzzKata();
        var result = fizzBuzz.Stringify(30);
        Assert.Equal("FizzBuzz", result);
    }
}