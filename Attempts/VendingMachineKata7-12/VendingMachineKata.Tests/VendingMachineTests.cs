namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void SelectProduct_InputA01_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A01");
        Assert.Equal("Soda",vendingMachine.selectedProduct);
    }

    [Fact]
    public void SelectProduct_InputA02_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A02");
        Assert.Equal("Chips", vendingMachine.selectedProduct);
    }

    [Fact]
    public void SelectProduct_InputA03_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A03");
        Assert.Equal("Candy", vendingMachine.selectedProduct);
    }

    [Fact]
    public void SelectProduct_InputA04_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A04");
        Assert.Equal("Gum", vendingMachine.selectedProduct);   
    }

    [Fact]
    public void SelectProduct_InputInvalidCode_ReturnInvalidCodeError()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("AAA");
        Assert.Equal("Invalid Selection: AAA", vendingMachine.Output);   
    }
    
    [Fact]
    public void AcceptChange_InputQuarter_Return25()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.AcceptChange(25);
        Assert.Equal(25,vendingMachine.changeEntered);
    }

    [Fact]
    public void AcceptChange_InputTwoQuarters_Return50()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        Assert.Equal(50, vendingMachine.changeEntered);
    }
    
    [Fact]
    public void VendProduct_InputFourQuarters_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        Assert.Equal("Vending Soda", vendingMachine.Output);
    }
    
    [Fact]
    public void VendProduct_InputCorrectChange_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(10);
        vendingMachine.AcceptChange(5);
        Assert.Equal("Vending Chips", vendingMachine.Output);
    }
    
    [Fact]
    public void VendProduct_InputCorrectChange_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(10);
        Assert.Equal("Vending Candy", vendingMachine.Output);
    }
    
    [Fact]
    public void VendProduct_InputCorrectChange_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(10);
        vendingMachine.AcceptChange(5);
        Assert.Equal("Vending Gum", vendingMachine.Output);
    }
    
    [Fact]
    public void VendProduct_InputExtraChange_ReturnChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        Assert.Equal("Vending Soda: Change $0.25", vendingMachine.Output);
    }
        
    [Fact]
    public void VendProduct_InputNotEnoughChange_ReturnFeedMeMessage()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        Assert.Equal("Feed me $0.25 more", vendingMachine.Output);
    }
    
    [Fact]
    public void VendProduct_InputItemCode_ReturnQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A01");
        Assert.Equal(10, item.Quantity);
    }
    
    [Fact]
    public void VendProduct_InputItemCode_ReturnQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A01");
        vendingMachine.SelectProduct("A01");
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        vendingMachine.AcceptChange(25);
        Assert.Equal(9, item.Quantity);
    }
    
    // [Fact]
    // public void VendProduct_InputItemCode_ReturnOutOfStockMessage()
    // {
    //     var vendingMachine = new VendingMachine();
    //     var item = vendingMachine.items.FirstOrDefault(x => x.Code == "A01");
    //     vendingMachine.SelectProduct("A01");
    //     vendingMachine.AcceptChange(25);
    //     vendingMachine.AcceptChange(25);
    //     vendingMachine.AcceptChange(25);
    //     vendingMachine.AcceptChange(25);
    //     Assert.Equal("Sold Out: Soda", vendingMachine.Output);
    // }
}