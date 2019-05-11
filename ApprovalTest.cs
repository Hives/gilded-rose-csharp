using System;
using System.IO;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/../../ThirtyDaysWithConjuredManaCake.txt";
            var lines = File.ReadAllLines(path);

            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            String output = fakeoutput.ToString();

            var outputLines = output.Split('\n');
            for(var i = 0; i<Math.Min(lines.Length, outputLines.Length); i++) 
            {
                Console.WriteLine(lines[i]);
                Assert.AreEqual(lines[i], outputLines[i]);
            }
        }
    }
}
