using NUnit;
using NUnit.Framework;
using System;
using TestFramework;
namespace Tests
{
    [TestFixture]
    public class UnitTest1:BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            HomePage page = new HomePage();
            page.OpenPage();
            Console.WriteLine("ffff");
        }
    }
}
