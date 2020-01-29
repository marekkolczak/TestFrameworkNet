using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace TestFramework
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }
        public Browser()
        {
            SetBrowser();
    
        }
           
        public void Initialize()
        {

        }
        public void SetBrowser()
        {
            if (WebDriver == null)
            {
                string Browser = ConfigurationManager.AppSettings.Get("Browser");
                switch (Browser)
                {
                    case "Edge": { WebDriver = new EdgeDriver(); break; }
                    case "Chrome": { WebDriver = new ChromeDriver($"{ConfigurationManager.AppSettings.Get("ChromeDriverPath")}"); break; }
                    case "Firefox": { WebDriver = new FirefoxDriver(); break; }
                }
            }
            
        }
        
        public IWebElement FindElement(By methodBy)
        {
            return WebDriver.FindElement(methodBy);
        }


    }
}
