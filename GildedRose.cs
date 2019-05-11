using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly Dictionary<String, Action<Item>> UpdateMethods;
        private readonly Action<Item> DefaultUpdateMethod;
        
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            UpdateMethods = new Dictionary<string, Action<Item>>
            {
                {"Sulfuras, Hand of Ragnaros", updateSulfuras},
                {"Aged Brie", updateAgedBrie},
                {"Conjured Mana Cake", updateConjuredItem},
                {"Backstage passes to a TAFKAL80ETC concert", updateBackstagePass}
            };
            DefaultUpdateMethod = updateNormalItem;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
               UpdateItem(item); 
            }
        }

        private void UpdateItem(Item item)
        {
            if (UpdateMethods.ContainsKey(item.Name))
            {
                UpdateMethods[item.Name](item);
            }
            else
            {
                DefaultUpdateMethod(item);
            }
        }

        private void updateSulfuras(Item item)
        {
            
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

        private void updateAgedBrie(Item item)
        {
            updateSimpleItem(item, 1);
        }

        private void updateConjuredItem(Item item)
        {
            updateSimpleItem(item, -2);
        }

        private void updateNormalItem(Item item)
        {
            updateSimpleItem(item, -1);
        }

        private void updateSimpleItem(Item item, int increment)
        {
            if (item.SellIn > 0)
            {
                item.Quality += increment;
            }
            else
            {
                item.Quality += 2 * increment;
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
