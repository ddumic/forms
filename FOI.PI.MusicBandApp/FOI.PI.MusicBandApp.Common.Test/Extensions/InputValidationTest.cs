using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using FOI.PI.MusicBandApp.Common.Extensions;

namespace FOI.PI.MusicBandApp.Common.Test
{
    [TestClass]
    public class InputValidationTest
    {
        [TestMethod]
        public void TestIsInputEmpty()
        {
            var textBox = new TextBox();
            textBox.Text = "text";
            Assert.IsFalse(textBox.IsInputEmpty());
        }

        [TestMethod]
        public void TestIsInputMail()
        {
            var mail = new TextBox();
            mail.Text = "text";
            Assert.IsFalse(mail.IsInputMail());
        }
    }
}
