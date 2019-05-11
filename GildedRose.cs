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
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        updateBackstagePass(item);
                        break;
                    case "Aged Brie":
                        updateSimpleItem(item, 1);
                        break;
                    default:
                        updateSimpleItem(item, -1);
                        break;
                }
            }
        }

        private void updateSimpleItem(Item item, int increment)
        {
            item.Quality += item.SellIn > 0 ? increment : 2 * increment;
            item.SellIn -= 1;
            CheckQualityLimits(item);
        }

        private void updateBackstagePass(Item item)
        {
            if (item.SellIn > 10)
            {
                item.Quality += 1;
            }

            if (item.SellIn > 5 && item.SellIn <= 10)
            {
                item.Quality += 2;
            }

            if (item.SellIn > 0 && item.SellIn <= 5)
            {
                item.Quality += 3;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            item.SellIn -= 1;
            CheckQualityLimits(item);
        }

        private void CheckQualityLimits(Item item)
        {
            item.Quality = Math.Max(item.Quality, 0);
            item.Quality = Math.Min(item.Quality, 50);
        }
    }
}
