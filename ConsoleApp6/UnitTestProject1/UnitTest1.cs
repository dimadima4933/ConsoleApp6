using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
        public void TestMethod1()
        {
            Dictionary<string, int> result = ConsoleApp6.Program.dictionary(@"C:\g\gg.txt");
            bool flag = true;
            if (result == null)
                flag = false;
            Assert.IsTrue(flag);
        }
        //тест на существование файла
        [TestMethod]
        public void TestMethod2()
        {
            bool flag = true;
            if (!File.OpenRead(@"C:\g\gg.txt").CanRead)
                flag = false;

            Assert.IsTrue(flag);
        }

    }
}