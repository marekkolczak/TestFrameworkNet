using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public  class HomePage
    {
        Driver WebDriver => new Driver();
        public  HomePage()
            {
           
            }
        public void  OpenPage()
        {

            var Url= ConfigurationManager.AppSettings["PageUrl"];
            WebDriver.WebDriver.Navigate().GoToUrl(Url);
        }
    }
}
