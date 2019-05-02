using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using static TestAutomationWeb.NetCore2.Utils.WebDriverFactory;

namespace TestAutomationWeb.NetCore2.Utils
{
    public class WebDriverExtensions
    {
        private readonly IWebDriver webDriver;
        public WebDriverExtensions()
        {
            this.webDriver = GetDriver(false);
        }

        public void LoadPage(TimeSpan timeToWait, string host)
        {
            webDriver.Manage().Timeouts().PageLoad = timeToWait;
            webDriver.Navigate().GoToUrl(host);
        }
        public void LoadPage(TimeSpan timeToWait, string host, string hash)
        {
            this.LoadPage(timeToWait, host + hash);
        }
        public void LoadPage(TimeSpan timeToWait, string host, string hash, string path)
        {
            this.LoadPage(timeToWait, host + hash + path);
        }

        public void ChangewindowFocus(int idx)
        {
            ReadOnlyCollection<string> windowHandles = webDriver.WindowHandles;
            webDriver.SwitchTo().Window(windowHandles[idx]);
        }
        public void CloseWindow()
        {
            webDriver.Close();
            ReadOnlyCollection<string> windowHandles = webDriver.WindowHandles;
            webDriver.SwitchTo().Window(windowHandles[0]);
        }

        public string GetUrl()
        {
            return webDriver.Url;
        }

        /********* TextField e TextArea ************/
        public void SetText(By by, string text, bool clear = true)
        {
            if (clear)
            {
                webDriver.FindElement(by).Clear();
            }
            webDriver.FindElement(by).SendKeys(text);
        }
        public void SetText(string Id, string text, bool clear = true)
        {
            this.SetText(By.Id(Id), text, clear);
        }
        public string GetText(By by)
        {
            return webDriver.FindElement(by).GetAttribute("value");
        }
        public string GetText(string Id)
        {
            return this.GetText(By.Id(Id));
        }
        /********* Radio e CheckBox ************/
        public void Click(By by)
        {
            webDriver.FindElement(by).Click();
        }

        public void Click(string Id)
        {
            this.Click(By.Id(Id));
        }
        public void ClickRadio(string Id)
        {
            this.Click(By.Id(Id));
        }
        public void ClickCheckBox(string Id)
        {
            this.Click(By.Id(Id));
        }
        public bool IsMarked(By by)
        {
            return webDriver.FindElement(by).Selected;
        }
        public bool IsRadioMarked(string Id)
        {
            return IsMarked(By.Id(Id));
        }
        public bool IsCheckBoxMarked(By by)
        {
            return IsMarked(by);
        }
        /********* Combo ************/
        public void SelectCombo(String Id, String Value)
        {
            IWebElement element = webDriver.FindElement(By.Id(Id));
            // SelectElement Selec_Event = new SelectElement
        }



    }
}