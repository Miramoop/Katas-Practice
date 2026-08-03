using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("foo", Items[0].Name);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityZero_ReturnQualityZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityOne_ReturnQualityZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 1 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityTwoSellInZero_ReturnQualityZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityTwoSellInOne_ReturnQualityOne()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 2 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(1, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityTwoSellInNegativeOne_ReturnQualityZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -1, Quality = 2 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooQualityFifty_ReturnQualityFortyEight()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 50 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(48, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenfooSellInZero_ReturnSellInNegativeOne()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-1, Items[0].SellIn);
    }
    [Fact]
    public void UpdateQuality_GivenBrieQualityTwo_ReturnQualityFour()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(4, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBrieQualityFiftyFive_ReturnQualityFiftyFive()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 55 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(55, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBrieSellInOne_ReturnQualitySix()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(6, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInZero_ReturnQualityZero()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInZero_ReturnQualityEight()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(8, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInTwo_ReturnQualitySix()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(6, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInSeven_ReturnQualitySeven()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(7, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInSeven_ReturnQualitySix()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(6, Items[0].SellIn);
    }
    [Fact]
    public void UpdateQuality_GivenBackstageQualityFiveSellInZero_ReturnSellInNegativeOne()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(-1, Items[0].SellIn);
    }
    [Fact]
    public void UpdateQuality_GivenSulfurasQualityFive_ReturnQualityFive()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(5, Items[0].Quality);
    }
    [Fact]
    public void UpdateQuality_GivenSulfurasSellInFive_ReturnSellInFive()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 5 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(5, Items[0].SellIn);
    }
}