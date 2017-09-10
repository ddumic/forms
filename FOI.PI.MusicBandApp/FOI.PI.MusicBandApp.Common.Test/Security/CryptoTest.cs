using Microsoft.VisualStudio.TestTools.UnitTesting;
using FOI.PI.MusicBandApp.Common.Security;

namespace FOI.PI.MusicBandApp.Common.Test
{
    [TestClass]
    public class CryptoTest
    {
        [TestMethod]
        public void TestAesDecrypt()
        {
            var inputString = "pyftuTRp1Vugi1VGszrzVw==??GrESiwD04Dx33FkbwQKQ/g==";
            Assert.AreEqual("test", inputString.Decrypt());
        }
    }
}
