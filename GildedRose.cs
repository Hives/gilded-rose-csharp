using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = item.Quality - 1;
                    }
                    else
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                            {
                                item.Quality = item.Quality + 1;
                            }

                            if (item.SellIn < 6)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }

                    if (item.SellIn <= 0)
                    {
                        switch (item.Name)
                        {
                            case "Backstage passes to a TAFKAL80ETC concert":
                                item.Quality = 0;
                                break;
                            case "Aged Brie":
                                item.Quality = item.Quality + 1;
                                break;
                            default:
                                item.Quality = item.Quality - 1;
                                break;
                        }
                    }
                    
                    item.SellIn = item.SellIn - 1;

                    item.Quality = Math.Max(item.Quality, 0);
                    item.Quality = Math.Min(item.Quality, 50);

                }
            }
        }
    }
}
