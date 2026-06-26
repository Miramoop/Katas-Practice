namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void SelectItem_GivenA01_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectItem("A01");
        Assert.Equal("Soda", result);
    }
    
    [Fact]
    public void SelectItem_GivenA02_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectItem("A02");
        Assert.Equal("Chips", result);
    }
    
    [Fact]
    public void SelectItem_GivenA03_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectItem("A03");
        Assert.Equal("Candy", result);
    }
    
    [Fact]
    public void SelectItem_GivenA04_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectItem("A04");
        Assert.Equal("Gum", result);
    }
    
    [Fact]
    public void SelectItem_GivenInvalidCode_ReturnError()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectItem("AAA");
        Assert.Equal("Invalid Code Entered", result);
    }
    
    [Fact]
    public void InputChange_GivenOneQuarter_Return25()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.InputChange(25);
        Assert.Equal("25", result);
    }
    
    [Fact]
    public void InputChange_GivenTwoQuarters_Return50()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        Assert.Equal("50", vendingMachine.changeEntered.ToString());
    }
    
    [Fact]
    public void CompletePurchase_GivenA01After4Quarters_ReturnVendingSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectItem("A01");
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        Assert.Equal("Vending Soda", vendingMachine.output);
    }
    
    [Fact]
    public void CompletePurchase_GivenA02AfterCorrectChange_ReturnVendingChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectItem("A02");
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        Assert.Equal("Vending Chips", vendingMachine.output);
    }
    
    [Fact]
    public void CompletePurchase_GivenA01AfterCorrectChange_ReturnVendingCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectItem("A03");
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        Assert.Equal("Vending Candy", vendingMachine.output);
    }
    
    [Fact]
    public void CompletePurchase_GivenA04AfterCorrectChange_ReturnVendingGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectItem("A04");
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(10);
        vendingMachine.InputChange(5);
        Assert.Equal("Vending Gum", vendingMachine.output);
    }
    
    [Fact]
    public void CompletePurchase_GivenA01AfterExtraChange_ReturnSodaAndExtraChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectItem("A01");
        var result = vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        vendingMachine.InputChange(25);
        Assert.Equal("Vending Soda: Change $0.25", vendingMachine.output);
    }
}