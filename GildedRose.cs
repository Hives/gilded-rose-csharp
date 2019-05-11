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

                            if (item.Quality > 0 && item.SellIn <= 5)
                            {
                                item.Quality += 3;
                            }
                            
                            if (item.Quality <= 0)
                            {
                                item.Quality = 0;
                            }

                            break;
                        case "Aged Brie":
                            item.Quality += item.SellIn > 0 ? 1 : 2;
                            break;
                        default:
                            item.Quality -= item.SellIn > 0 ? 1 : 2;
                            break;
                    }
                    
                    item.SellIn -= 1;

                    item.Quality = Math.Max(item.Quality, 0);
                    item.Quality = Math.Min(item.Quality, 50);

                }
            }
        }
    }
}
