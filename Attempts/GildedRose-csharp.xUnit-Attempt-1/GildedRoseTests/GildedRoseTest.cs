using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void UpdateQuality_GivenNormalItemWithQualityGreaterThanZero_DecreaseQualityBy1()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = 10, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(4, Items[0].Quality);
    }
    
    [Fact]
    public void UpdateQuality_GivenNormalItem_DecreaseSellInBy1()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = 10, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(9, Items[0].SellIn);
    }
    
    [Fact]
    public void UpdateQuality_GivenNormalItemWithNegativeSellInAndPositiveQuality_DecreaseQualityBy2()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = -5, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(3, Items[0].Quality);
    }
    
    [Fact]
    public void UpdateQuality_GivenNormalItemWithNegativeSellInAndNegativeQuality_KeepQualityTheSame()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = -5, Quality = -5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-5, Items[0].Quality);
    }
    
    [Fact]
    public void UpdateQuality_GivenNormalItemWithNegativeSellInAndZeroQuality_KeepQualityTheSame()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "NormalItem", SellIn = -5, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
}