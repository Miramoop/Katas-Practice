using VendingMachineBase;

namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void SelectProduct_GivenA01_ReturnSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        Assert.Equal("Soda",vendingMachine.selectedItem);
    }
    
    [Fact]
    public void SelectProduct_GivenA02_ReturnChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        Assert.Equal("Chips",vendingMachine.selectedItem);
    }
    
    [Fact]
    public void SelectProduct_GivenA03_ReturnCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        Assert.Equal("Candy",vendingMachine.selectedItem);
    }
    
    [Fact]
    public void SelectProduct_GivenA04_ReturnGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        Assert.Equal("Gum",vendingMachine.selectedItem);
    }
    
    [Fact]
    public void SelectProduct_GivenInvalidCode_ReturnInvalidSelection()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.SelectProduct("AAA");
        Assert.Equal("Invalid Selection: AAA",result);
    }
    
    [Fact]
    public void CalculateChange_GivenOneQuarter_Return25()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.CalculateChange(25);
        Assert.Equal(25,vendingMachine.totalChange);
    }
    
    [Fact]
    public void CalculateChange_GivenTwoQuarters_Return50()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        Assert.Equal(50,vendingMachine.totalChange);
    }
    
    [Fact]
    public void VendProduct_GivenCorrectChange_ReturnVendingSoda()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Soda",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenCorrectChange_ReturnVendingChips()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.CalculateChange(5);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Chips",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenCorrectChange_ReturnVendingCandy()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Candy",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenCorrectChange_ReturnVendingGum()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.CalculateChange(5);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Gum",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenExtraChange_ReturnVendingSodaWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Soda: Change $0.25",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenExtraChange_ReturnVendingChipsWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Chips: Change $0.10",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenExtraChange_ReturnVendingCandyWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Candy: Change $0.15",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenExtraChange_ReturnVendingGumWithChange()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Vending Gum: Change $0.10",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenNotEnoughChange_ReturnFeedMe25Message()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Feed me $0.25 more",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenNotEnoughChange_ReturnFeedMe15Message()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Feed me $0.15 more",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenNotEnoughChange_ReturnFeedMe10Message()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Feed me $0.10 more",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenNotEnoughChange_ReturnFeedMe20Message()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        vendingMachine.CalculateChange(10);
        vendingMachine.CalculateChange(10);
        vendingMachine.VendProduct();
        Assert.Equal("Feed me $0.20 more",vendingMachine.output);
    }
    
    [Fact]
    public void VendingMachine_GivenSoda_ReturnSodaQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        Assert.Equal(10,item.Quantity);
    }
    
    [Fact]
    public void VendingMachine_GivenChips_ReturnChipsQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        Assert.Equal(12,item.Quantity);
    }
    
    [Fact]
    public void VendingMachine_GivenCandy_ReturnCandyQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        Assert.Equal(8,item.Quantity);
    }
    
    [Fact]
    public void VendingMachine_GivenGum_ReturnGumQuantity()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        Assert.Equal(3,item.Quantity);
    }
    
    [Fact]
    public void VendProduct_GivenSodaQuantity_ReturnQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A01");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        Assert.Equal(9,item.Quantity);
    }
    
    [Fact]
    public void VendProduct_GivenChipsQuantity_ReturnQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A02");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        Assert.Equal(11,item.Quantity);
    }
    
    [Fact]
    public void VendProduct_GivenCandyQuantity_ReturnQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A03");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.VendProduct();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        Assert.Equal(7,item.Quantity);
    }
    
    [Fact]
    public void VendProduct_GivenGumQuantity_ReturnQuantityMinusOne()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.SelectProduct("A04");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.CalculateChange(5);
        vendingMachine.VendProduct();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        Assert.Equal(2,item.Quantity);
    }
    
    [Fact]
    public void VendProduct_GivenSodaQuantity0_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A01");
        item.Quantity = 0;
        vendingMachine.SelectProduct("A01");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Sold Out: Soda",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenChipsQuantity0_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A02");
        item.Quantity = 0;
        vendingMachine.SelectProduct("A02");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Sold Out: Chips",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenCandyQuantity0_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A03");
        item.Quantity = 0;
        vendingMachine.SelectProduct("A03");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(25);
        vendingMachine.VendProduct();
        Assert.Equal("Sold Out: Candy",vendingMachine.output);
    }
    
    [Fact]
    public void VendProduct_GivenGumQuantity0_ReturnSoldOutMessage()
    {
        var vendingMachine = new VendingMachine();
        var item = vendingMachine.Items.FirstOrDefault(x => x.Code == "A04");
        item.Quantity = 0;
        vendingMachine.SelectProduct("A04");
        vendingMachine.CalculateChange(25);
        vendingMachine.CalculateChange(10);
        vendingMachine.CalculateChange(5);
        vendingMachine.VendProduct();
        Assert.Equal("Sold Out: Gum",vendingMachine.output);
    }
}