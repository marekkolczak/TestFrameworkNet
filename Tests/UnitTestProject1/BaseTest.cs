using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework;

namespace UnitTestProject1
{
    public  class BaseTest
    {
        Driver driver;
        public BaseTest() { SetUp(); }
        [SetUp]
        public  void SetUp()
        {
             driver = new Driver();
             new HomePage().OpenPage();
        }
        [TearDown]
        public void TearDown()
        {
            driver.WebDriver.Close();
            driver.WebDriver.Dispose();
        }

    }
}
