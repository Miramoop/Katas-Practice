using csharp.xUnit___FizzBuzzExample;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Fact]
    public void Stringify_Given1_Return1()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(1);
        Assert.Equal("1", result);
    }
    
    [Fact]
    public void Stringify_Given2_Return2()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(2);
        Assert.Equal("2", result);
    }
    
    [Fact]
    public void Stringify_Given3_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(3);
        Assert.Equal("Fizz", result);
    }
    
    [Fact]
    public void Stringify_Given5_ReturnBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(5);
        Assert.Equal("Buzz", result);
    }
    
    [Fact]
    public void Stringify_Given6_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(6);
        Assert.Equal("Fizz", result);
    }
    
    [Fact]
    public void Stringify_Given9_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(9);
        Assert.Equal("Fizz", result);
    }
    
    [Fact]
    public void Stringify_Given10_ReturnBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(10);
        Assert.Equal("Buzz", result);
    }
    
    [Fact]
    public void Stringify_GivenMultipleOf3_ReturnFizz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(33);
        Assert.Equal("Fizz", result);
    }
    
    [Fact]
    public void Stringify_GivenMultipleOf5_ReturnBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(50);
        Assert.Equal("Buzz", result);
    }
    
    [Fact]
    public void Stringify_Given15_ReturnFizzBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(15);
        Assert.Equal("FizzBuzz", result);
    }
    
    [Fact]
    public void Stringify_GivenMultipleOf3And5_ReturnFizzBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = FizzBuzz.Stringify(30);
        Assert.Equal("FizzBuzz", result);
    }
}