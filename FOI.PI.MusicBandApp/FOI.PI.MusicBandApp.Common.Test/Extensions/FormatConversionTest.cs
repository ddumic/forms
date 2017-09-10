using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FOI.PI.MusicBandApp.Common.Extensions;

namespace FOI.PI.MusicBandApp.Common.Test
{
    [TestClass]
    public class FormatConversionTest
    {
        [TestMethod]
        public void TestToDouble()
        {
            string input = "2";
            Assert.AreEqual(2.0, input.ToDouble());
        }

        [TestMethod]
        public void TestToTimeSpan()
        {
            string timeSpan = "00:05:21";
            Assert.AreEqual(new TimeSpan(long.Parse("3210000000")), timeSpan.ToTimeSpan());
        }

        [TestMethod]
        public void TestToInt()
        {
            string integer = "1";
            Assert.AreEqual(1, integer.ToInt());
        }
    }
}
