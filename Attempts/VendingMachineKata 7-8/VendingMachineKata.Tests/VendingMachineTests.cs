namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void Vend_InputA01_OutputSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A01");
        Assert.Equal("Soda",result);
    }
    
    [Fact]
    public void Vend_InputA02_OutputChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A02");
        Assert.Equal("Chips",result);
    }
    
    [Fact]
    public void Vend_InputA03_OutputCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A03");
        Assert.Equal("Candy",result);   
    }
    
    [Fact]
    public void Vend_InputA04_OutputGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A04");
        Assert.Equal("Gum",result);   
    }
    
    [Fact]
    public void CountChange_InputQuarter_Output25()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.CountChange(25);
        Assert.Equal(25, vendingMachine.inputtedChange);   
    }
    
    [Fact]
    public void CountChange_InputTwoQuarters_Output50()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        Assert.Equal(50,vendingMachine.inputtedChange);   
    }
    
    [Fact]
    public void CountChange_InputFourQuarters_OutputSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A01");
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        Assert.Equal("Vending Soda",vendingMachine.output);   
    }
    
    [Fact]
    public void CountChange_InputCorrectChange_OutputChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A02");
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(10);
        vendingMachine.CountChange(5);
        Assert.Equal("Vending Chips",vendingMachine.output);   
    }
    
    [Fact]
    public void CountChange_InputCorrectChange_OutputCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A03");
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(10);
        Assert.Equal("Vending Candy",vendingMachine.output);   
    }
    
    [Fact]
    public void CountChange_InputCorrectChange_OutputGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A04");
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(10);
        vendingMachine.CountChange(5);
        Assert.Equal("Vending Gum",vendingMachine.output);   
    }
    
    [Fact]
    public void CountChange_InputExtraChange_OutputExtraChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        vendingMachine.CountChange(25);
        Assert.Equal("Vending Soda: Change $0.25",vendingMachine.output);   
    }
}