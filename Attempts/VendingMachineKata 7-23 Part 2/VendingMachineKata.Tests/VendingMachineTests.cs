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
    public void Vend_GivenInvalidCode_ReturnInvalidSelectionCode()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("AAA");
        Assert.Equal("Invalid Selection: AAA", vendingMachine.SelectedItem);
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
    public void EnterChange_GivenCorrectChange_ReturnVendingChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A02");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(10);
        vendingMachine.EnterChange(5);
        Assert.Equal("Vending Chips", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenCorrectChange_ReturnVendingCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A03");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(10);
        Assert.Equal("Vending Candy", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenCorrectChange_ReturnVendingGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A04");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(10);
        vendingMachine.EnterChange(5);
        Assert.Equal("Vending Gum", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenExtraChange_ReturnVendingSodaWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Vending Soda: Change $0.25", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenExtraChange_ReturnVendingChipsWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A02");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Vending Chips: Change $0.10", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenExtraChange_ReturnVendingCandyWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A03");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Vending Candy: Change $0.15", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenExtraChange_ReturnVendingGumWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A04");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Vending Gum: Change $0.10", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenA01NotEnoughChange_ReturnFeedMeMessageChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Feed me $0.50 more", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenA02NotEnoughChange_ReturnFeedMeMessageChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A02");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Feed me $0.15 more", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenA03NotEnoughChange_ReturnFeedMeMessageChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A03");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Feed me $0.10 more", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenA04NotEnoughChange_ReturnFeedMeMessageChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A04");
        vendingMachine.EnterChange(25);
        Assert.Equal("Feed me $0.15 more", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenSoda_ReturnQuantityReducedBy1()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A01");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        Assert.Equal(9, item.Quantity);
    }
    
    [Fact]
    public void EnterChange_GivenChips_ReturnQuantityReducedBy1()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A02");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        Assert.Equal(11, item.Quantity);
    }
    
    [Fact]
    public void EnterChange_GivenCandy_ReturnQuantityReducedBy1()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A03");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(10);
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        Assert.Equal(7, item.Quantity);
    }
    
    [Fact]
    public void EnterChange_GivenGum_ReturnQuantityReducedBy1()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.Vend("A04");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        Assert.Equal(2, item.Quantity);
    }
    
    [Fact]
    public void EnterChange_GivenSodaQuantityZero_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        item.Quantity = 0;
        vendingMachine.Vend("A01");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Sold Out: Soda", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenChipsQuantityZero_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        item.Quantity = 0;
        vendingMachine.Vend("A02");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Sold Out: Chips", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenCandyQuantityZero_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        item.Quantity = 0;
        vendingMachine.Vend("A03");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(10);
        Assert.Equal("Sold Out: Candy", vendingMachine.Output);
    }
    
    [Fact]
    public void EnterChange_GivenGumQuantityZero_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        item.Quantity = 0;
        vendingMachine.Vend("A04");
        vendingMachine.EnterChange(25);
        vendingMachine.EnterChange(25);
        Assert.Equal("Sold Out: Gum", vendingMachine.Output);
    }
    
    [Fact]
    public void InstantiateVendingMachine_GivenSoda_ReturnQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        Assert.Equal(10, item.Quantity);
    }
    
    [Fact]
    public void InstantiateVendingMachine_GivenChips_ReturnQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        Assert.Equal(12, item.Quantity);
    }
    
    [Fact]
    public void InstantiateVendingMachine_GivenCandy_ReturnQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        Assert.Equal(8, item.Quantity);
    }
    
    [Fact]
    public void InstantiateVendingMachine_GivenGum_ReturnQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        Assert.Equal(3, item.Quantity);
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