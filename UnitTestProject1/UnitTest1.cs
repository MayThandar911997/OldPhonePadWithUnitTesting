using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OldPhoneApp app = new OldPhoneApp();
            string output = "";
            output = app.OldPhonePad("33#");
            Console.WriteLine(output);
            output = app.OldPhonePad("227*#");
            Console.WriteLine(output);
            output = app.OldPhonePad("4433555 555666#");
            Console.WriteLine(output);
            output = app.OldPhonePad("8 88777444666*664#");
            Console.WriteLine(output);
        }
    }
}
