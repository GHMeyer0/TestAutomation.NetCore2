using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationWeb.NetCore2.Utils
{
    class WebDriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver(bool headless = true)
        {
            if (driver == null)
            {
                switch (Configuration.browser)
                {
                    case Browser.Firefox:
                        FirefoxOptions firefoxOptions = new FirefoxOptions();
                        if (headless)
                        {
                            firefoxOptions.AddArgument("--headless");
                        }
                        driver = new FirefoxDriver(firefoxOptions);
                        break;

                    case Browser.Chrome:
                        ChromeOptions chromeOptions = new ChromeOptions();
                        if (headless)
                        {
                            chromeOptions.AddArgument("--headless");
                        }
                        driver = new ChromeDriver();
                        break;

                    case Browser.Edge:
                        driver = new EdgeDriver();
                        break;

                    case Browser.InternetExplorer:
                        driver = new InternetExplorerDriver();
                        break;
                }
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void KillDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
