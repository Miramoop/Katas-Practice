using System.Collections.Generic;

namespace GildedRoseKata;

// Look into polymorphism to refactor more!!

public class GildedRose
{
    public const string AgedBrie = "Aged Brie";
    public const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
    public const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            if (Items[i].Name == SulfurasHandOfRagnaros)
            {
                continue;
            }

            switch (Items[i].Name)
            {
                case AgedBrie:
                {
                    IncreaseQualityIfPossible(i);
                    break;
                }
                case BackstagePassesToATafkal80EtcConcert:
                {
                    UpdateBackstagePass(i);
                    break;
                }
                default:
                {
                    if (Items[i].Quality > 0)
                    {
                        ReduceQualityBy1(i);
                    }

                    break;
                }
            }

            Items[i].SellIn--;

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name == AgedBrie)
                {
                    IncreaseQualityIfPossible(i);
                }
                else
                {
                    if (Items[i].Name == BackstagePassesToATafkal80EtcConcert)
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                    else
                    {
                        if (Items[i].Quality > 0)
                        {
                            ReduceQualityBy1(i);
                        }
                    }
                }
            }
        }
    }
    
    private void UpdateBackstagePass(int i)
    {
        IncreaseQualityIfPossible(i);

        if (Items[i].SellIn < 11)
        {
            IncreaseQualityIfPossible(i);
        }

        if (Items[i].SellIn < 6)
        {
            IncreaseQualityIfPossible(i);
        }

        return;
    }

    private void IncreaseQualityIfPossible(int i)
    {
        if (Items[i].Quality < 50)
        {
            IncrementQualityBy1(i);
        }
    }

    private int IncrementQualityBy1(int i)
    {
        return Items[i].Quality = Items[i].Quality + 1;
    }
    
    private void ReduceQualityBy1(int i)
    {
        Items[i].Quality = Items[i].Quality - 1;
    }
}