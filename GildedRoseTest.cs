using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GuildedRoseTests
    {
        [Test, Description("An item's name should be unchanged")]
        [Category("Normal item tests")]
        public void NormalItemName()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }
        
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 5")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemWithinSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 1")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemApproachingSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 2 when SellIn = 0")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemAtSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality decreases by 2 when SellIn < 0")]
        [Category("Normal item tests")]
        public void UpdateQualityOfNormalItemBeyondSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can decrease to 0 before SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCanDecreaseToZeroBeforeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can't decrease beyond 0 before SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCantDecreaseBelowZeroBeforeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can decrease to 0 after SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCanDecreaseToZeroAfterSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test, Description("A normal item's quality can't decrease beyond 0 after SellIn")]
        [Category("Normal item tests")]
        public void NormalItemQualityCantDecreaseBelowZeroAfterSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        [Test, Description("A normal item's SellIn decreases by 1")]
        [Category("Normal item tests")]
        public void UpdateSellInOfNormalItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].SellIn);
        }
        
        
        [Test, Description("Aged Brie's name should be unchanged")]
        [Category("Aged Brie tests")]
        public void AgedBrieName()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
        }
        
        [Test, Description("Aged Brie's quality increases by 1 when SellIn = 5")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieWithinSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 1 when SellIn = 1")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieApproachingSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 2 when SellIn = 0")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieAtSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(7, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases by 2 when SellIn < 0")]
        [Category("Aged Brie tests")]
        public void UpdateQualityOfAgedBrieBeyondSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(7, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can increase beyond 49 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt49AndInDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can't increase beyond 50 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt50AndInDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality increases from 49 to 50 after SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt49AndOutOfDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's quality can't increase beyond 50 before SellIn")]
        [Category("Aged Brie tests")]
        public void UpdateAgedBrieWhenQualityAt50AndOutOfDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
        
        [Test, Description("Aged Brie's SellIn decreases by 1")]
        [Category("Aged Brie tests")]
        public void UpdateSellInOfAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].SellIn);
        }
    }
}
