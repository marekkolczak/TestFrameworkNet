using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestFramework;

namespace UnitTestProject1
{
       
    public  class BaseTest
    {
        public BaseTest()
        {
            if (homePage==null)
            homePage = new HomePage();
        }

        HomePage homePage;
       
        [SetUp]
        public  void SetUp()
        {
           
              homePage.OpenPage();
        }
        [TearDown]
        public void TearDown()
        {
            homePage.Browser.WebDriver.Close();
            homePage.Browser.WebDriver.Dispose();
            Process.GetProcessesByName("chromedriver").ToList().ForEach(x => x.Kill());
        }

    }
}
