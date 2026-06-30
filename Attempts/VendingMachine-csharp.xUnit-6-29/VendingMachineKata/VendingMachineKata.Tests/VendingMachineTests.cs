namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void Vend_GivenSodaCode_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A01");
        Assert.Equal("Soda", result);
    }
    
    [Fact]
    public void Vend_GivenChipsCode_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A02");
        Assert.Equal("Chips", result);
    }
    
    [Fact]
    public void Vend_GivenCandyCode_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A03");
        Assert.Equal("Candy", result);
    }
    
    [Fact]
    public void Vend_GivenGumCode_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A04");
        Assert.Equal("Gum", result);
    }
    
    [Fact]
    public void Vend_GivenInvalidCode_ReturnInvalidCodeMessage()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.Vend("A08");
        Assert.Equal("Invalid Selection: A08", result);
    }
    
    [Fact]
    public void InputChange_GivenOneQuarter_ReturnTwentyFive()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        Assert.Equal(25, vendingMachine.ChangeEntered);
    }
    
    [Fact]
    public void InputChange_GivenTwoQuarters_ReturnFifty()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        Assert.Equal(50, vendingMachine.ChangeEntered);
    }
    
    [Fact]
    public void InputChange_GivenFourQuarters_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.Vend("A01");
        Assert.Equal("Vending Soda", vendingMachine.Output);
    }
    
    [Fact]
    public void InputChange_GivenCorrectChange_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A02");
        Assert.Equal("Vending Chips", vendingMachine.Output);
    }
    
    [Fact]
    public void InputChange_GivenCorrectChange_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.Vend("A03");
        Assert.Equal("Vending Candy", vendingMachine.Output);
    }
    
    [Fact]
    public void InputChange_GivenCorrectChange_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A04");
        Assert.Equal("Vending Gum", vendingMachine.Output);
    }
    
    [Fact]
    public void InputChange_GivenExtraChange_ReturnGumAndChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.Vend("A04");
        Assert.Equal((decimal)0.60, vendingMachine.ExtraChange);
        Assert.Equal("Vending Gum: Change $0.60", vendingMachine.Output);
    }
    
    [Fact]
    public void InputChange_GivenInsufficientChange_ReturnFeedMeMessage()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InputChange(25);
        vendingMachine.Vend("A04");
        Assert.Equal((decimal)0.15, vendingMachine.RequiredChange);
        Assert.Equal("Feed me $0.15 more", vendingMachine.Output);
    }
    
    [Fact]
    public void VendingMachine_GivenGum_ReturnGumQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A04");
        Assert.Equal(3, item.Quantity);
    }
    
    [Fact]
    public void VendingMachine_GivenGum_ReturnGumQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A04");
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A04");
        Assert.Equal(2, item.Quantity);
    }
    
    [Fact]
    public void VendingMachine_GivenGum_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A04");
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A04");
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A04");
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        vendingMachine.Vend("A04");
        vendingMachine.Vend("A04");
        Assert.Equal(0, item.Quantity);
        Assert.Equal($"Sold Out: Gum",vendingMachine.Output);
    }
}