namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void Vend_GivenA01_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        Assert.Equal("Soda", vendingMachine.SelectedItem);
    }
    
    [Fact]
    public void Vend_GivenA02_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A02");
        Assert.Equal("Chips", vendingMachine.SelectedItem);
    }
    
    [Fact]
    public void Vend_GivenA03_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A03");
        Assert.Equal("Candy", vendingMachine.SelectedItem);
    }
    
    [Fact]
    public void Vend_GivenA04_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A04");
        Assert.Equal("Gum", vendingMachine.SelectedItem);
    }
    
    [Fact]
    public void Vend_GivenInvalidCode_ReturnInvalidCode()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("AAA");
        Assert.Equal("Invalid Code", vendingMachine.SelectedItem);
    }
    
    [Fact]
    public void EnterChange_GivenOneQuarter_Return25()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.EnterChange(25);
        Assert.Equal(25, vendingMachine.ChangeEntered);
    }
    
    [Fact]
    public void EnterChange_GivenTwoQuarters_Return50()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal(50, vendingMachine.ChangeEntered);
    }
    
    [Fact]
    public void EnterChange_GivenFourQuarters_ReturnVendingSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Vending Soda", vendingMachine.Output);
    }
    
    [Fact]
    public void InstantiateVendingMachine_ReturnWelcomeMessage()
    {
        var vendingMachine = new VendingMachine();
        Assert.Equal("Welcome", vendingMachine.Output);
    }
    
    [Fact]
    public void InstantiateVendingMachine_ReturnChangeEnteredEqualsZero()
    {
        var vendingMachine = new VendingMachine();
        Assert.Equal(0, vendingMachine.ChangeEntered);
    }
    
    [Fact]
    public void InstantiateVendingMachine_ReturnSelectedItemAsInvalidCode()
    {
        var vendingMachine = new VendingMachine();
        Assert.Equal("Invalid Code", vendingMachine.SelectedItem);
    }
}