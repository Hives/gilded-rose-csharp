using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

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
                    switch (item.Name)
                    {
                        case "Backstage passes to a TAFKAL80ETC concert":
                            if (item.SellIn > 10)
                            {
                                item.Quality += 1;
                            }

                            if (item.SellIn > 5 && item.SellIn <= 10)
                            {
                                item.Quality += 2;
                            }

                            if (item.SellIn <= 5)
                            {
                                item.Quality += 3;
                            }

                            break;
                        case "Aged Brie":
                            item.Quality += 1;
                            break;
                        default:
                            item.Quality -= 1;
                            break;
                    }

                    if (item.SellIn <= 0)
                    {
                        switch (item.Name)
                        {
                            case "Backstage passes to a TAFKAL80ETC concert":
                                item.Quality = 0;
                                break;
                            case "Aged Brie":
                                item.Quality += 1;
                                break;
                            default:
                                item.Quality -= 1;
                                break;
                        }
                    }
                    
                    item.SellIn -= 1;

                    item.Quality = Math.Max(item.Quality, 0);
                    item.Quality = Math.Min(item.Quality, 50);

                }
            }
        }
    }
}
