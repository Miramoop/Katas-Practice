namespace VendingMachineKata.Tests;

public class VendingMachineTests
{
    [Fact]
    public void SelectProduct_InputA01_ReturnSoda()
    {
        var selectProduct = new SelectProduct();
        var result = SelectProduct("A01");
        Assert.Equal("Soda",result);
    }
}