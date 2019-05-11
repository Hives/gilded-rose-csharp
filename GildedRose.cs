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
                    case "Conjured Mana Cake":
                        updateSimpleItem(item, -2);
                        break;
                    default:
                        updateSimpleItem(item, -1);
                        break;
                }
            }
        }

        private void updateSimpleItem(Item item, int smallIncrement)
        {
            var largeIncrement = 2 * smallIncrement;
            item.Quality += item.SellIn > 0 ? smallIncrement : largeIncrement;
            CheckQualityLimits(item);
            item.SellIn -= 1;
        }

        private void updateBackstagePass(Item item)
        {
            item.Quality++;
            
            if (item.SellIn <= 10)
            {
                item.Quality++;
            }

            if (item.SellIn <= 5)
            {
                item.Quality++;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            
            CheckQualityLimits(item);
            item.SellIn -= 1;
        }

        private void CheckQualityLimits(Item item)
        {
            item.Quality = Math.Max(item.Quality, 0);
            item.Quality = Math.Min(item.Quality, 50);
        }
    }
}
