namespace VendingMachineTests;

public class Tests
{
    [Fact]
    public void SelectProduct_InputA01_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A01");
        Assert.Equal("Soda",result);
    }

    [Fact]
    public void SelectProduct_InputA02_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A02");
        Assert.Equal("Chips", result);
    }

    [Fact]
    public void SelectProduct_InputA03_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A03");
        Assert.Equal("Candy", result);
    }

    [Fact]
    public void SelectProduct_InputA04_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("A04");
        Assert.Equal("Gum", result);   
    }

    [Fact]
    public void SelectProduct_InputInvalidCode_ReturnInvalidCodeError()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("AAA");
        Assert.Equal("Invalid Code", result);   
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
}