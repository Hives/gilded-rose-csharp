using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test, Description("An item's name should be unchanged")]
        public void NormalItemName()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 5")]
        public void UpdateQualityOfNormalItemWithinSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }
        [Test, Description("A normal item's quality decreases by 1 when SellIn = 1")]
        public void UpdateQualityOfNormalItemApproachingSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }
        [Test, Description("A normal item's quality decreases by 2 when SellIn = 0")]
        public void UpdateQualityOfNormalItemAtSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }
        [Test, Description("A normal item's quality decreases by 2 when SellIn < 0")]
        public void UpdateQualityOfNormalItemBeyondSellBy()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -2, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }
        [Test, Description("A normal item's SellIn decreases by 1")]
        public void UpdateSellInOfNormalItem()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].SellIn);
        }
    }
}
