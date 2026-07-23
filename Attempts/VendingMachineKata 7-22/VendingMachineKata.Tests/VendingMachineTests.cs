namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void VendProduct_InputCodeOutputProductName()
    {
        var vendingMachine = new VendingMachine();
        var result = vendingMachine.VendProduct("A01");
        Assert.Equal("Soda",result);
    }


}