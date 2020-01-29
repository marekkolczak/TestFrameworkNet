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
        public Browser Browser;
        public  HomePage()
            { 
            if (Browser==null)
            Browser = new Browser();
            }
        public void  OpenPage()
        {

            var Url= ConfigurationManager.AppSettings["PageUrl"];
            Browser.WebDriver.Navigate().GoToUrl(Url);
        }
    }
}
