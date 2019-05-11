using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test, Description("An item's name should be unchanged")]
        [Category("Normal item tests")]
        public void NormalItemName()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
        }
        
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 5")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemWithinSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 1")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemApproachingSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 2 when SellIn = 0")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemAtSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 2 when SellIn < 0")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemBeyondSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can decrease to 0 before SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCanDecreaseToZeroBeforeSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can't decrease beyond 0 before SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCantDecreaseBelowZeroBeforeSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can decrease to 0 after SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCanDecreaseToZeroAfterSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 2 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can't decrease beyond 0 after SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCantDecreaseBelowZeroAfterSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A normal item's SellIn decreases by 1")]
        [Category("Normal item tests")]
        public void UpdateSellInOfNormalItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].SellIn);
        }
        
        
        [Test, Description("An item's name should be unchanged")]
        [Category("Conjured item tests")]
        public void ConjuredItemName()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured Mana Cake", items[0].Name);
        }
        
        [Test, Description("A Conjured item's quality decreases by 2 when SellIn = 5")]
        [Category("Conjured item tests")]
        public void UpdateQualityOfConjuredItemWithinSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality decreases by 1 when SellIn = 1")]
        [Category("Conjured item tests")]
        public void UpdateQualityOfConjuredItemApproachingSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality decreases by 4 when SellIn = 0")]
        [Category("Conjured item tests")]
        public void UpdateQualityOfConjuredItemAtSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(1, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality decreases by 4 when SellIn < 0")]
        [Category("Conjured item tests")]
        public void UpdateQualityOfConjuredItemBeyondSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(1, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality can decrease to 0 before SellIn")]
        [Category("Conjured item tests")]
        public void ConjuredItemQualityCanDecreaseToZeroBeforeSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality can't decrease beyond 0 before SellIn")]
        [Category("Conjured item tests")]
        public void ConjuredItemQualityCantDecreaseBelowZeroBeforeSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality can decrease to 0 after SellIn")]
        [Category("Conjured item tests")]
        public void ConjuredItemQualityCanDecreaseToZeroAfterSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -2, Quality = 4 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's quality can't decrease beyond 0 after SellIn")]
        [Category("Conjured item tests")]
        public void ConjuredItemQualityCantDecreaseBelowZeroAfterSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -2, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A Conjured item's SellIn decreases by 1")]
        [Category("Conjured item tests")]
        public void UpdateSellInOfConjuredItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].SellIn);
        }
        
        
        [Test, Description("Aged Brie's name should be unchanged")]
        [Category("Aged Brie tests")]
        public void AgedBrieName()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", items[0].Name);
        }
        
        [Test, Description("Aged Brie's quality increases by 1 when SellIn = 5")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieWithinSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(6, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 1 when SellIn = 1")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieApproachingSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(6, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 2 when SellIn = 0")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieAtSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(7, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 2 when SellIn < 0")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieBeyondSellBy()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(7, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can increase beyond 49 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt49AndInDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can't increase beyond 50 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt50AndInDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases from 49 to 50 after SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt49AndOutOfDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can't increase beyond 50 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt50AndOutOfDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("Aged Brie's SellIn decreases by 1")]
        [Category("Aged Brie tests")]
        public void UpdateSellInOfAgedBrie()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].SellIn);
        }
        
        
        [Test, Description("An item's name should be unchanged")]
        [Category("Sulfuras tests")]
        public void SulfurasNameStaysTheSame()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 8, Quality = 8 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", items[0].Name);
        }
        
        [Test, Description("Sulfuras's quality does not change when SellIn positive")]
        [Category("Sulfuras tests")]
        public void UpdateSulfurasWithPositiveSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
        }
        
        [Test, Description("Sulfuras's quality does not change when SellIn zero")]
        [Category("Sulfuras tests")]
        public void UpdateSulfurasWithZeroSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
        }
        
        [Test, Description("Sulfuras's quality does not change when SellIn negative")]
        [Category("Sulfuras tests")]
        public void UpdateSulfurasWithNegativeSellIn()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
        }
        
        [Test, Description("Sulfuras' SellIn doesn't change")]
        [Category("Sulfuras tests")]
        public void UpdateSulfurasSellInDoesntChange()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].SellIn);
        }
        
        
        [Test, Description("An backstage pass's name should be unchanged")]
        [Category("Backstage pass tests")]
        public void BackstagePassName()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        }
        
        [Test, Description("A backstage pass's quality increases by 1 when SellIn = 15")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn15()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(6, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality increases by 1 when SellIn = 11")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn11()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(6, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality increases by 2 when SellIn = 10")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn10()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(7, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality increases by 2 when SellIn = 6")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn6()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(7, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality increases by 3 when SellIn = 5")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn5()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality increases by 3 when SellIn = 1")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn1()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality goes to 0 when SellIn = 0")]
        [Category("Backstage pass tests")]
        public void UpdateQualityOfBackstagePassWithSellIn0()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality can't increase beyond 50 when SellIn = 15")]
        [Category("Backstage pass tests")]
        public void BackStagepassQualityCantIncreaseBeyond50WithSellIn15()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality can't increase beyond 50 when SellIn = 7")]
        [Category("Backstage pass tests")]
        public void BackStagepassQualityCantIncreaseBeyond50WithSellIn7()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's quality can't increase beyond 50 when SellIn = 3")]
        [Category("Backstage pass tests")]
        public void BackStagepassQualityCantIncreaseBeyond50WithSellIn3()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 48 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test, Description("A backstage pass's SellIn decreases by 1")]
        [Category("Backstage pass tests")]
        public void UpdateSellInOfBackstagePass()
        {
            IList<Item> items = new List<Item> { new Item { Name = "BackstagePass", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].SellIn);
        }
    }
}
