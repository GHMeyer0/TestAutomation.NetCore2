using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationSrBarriga.NetCore2.Utils;
using static TestAutomationSrBarriga.NetCore2.Utils.WebDriverFactory;

namespace TestAutomationSrBarriga.NetCore2.Pages
{
    class BasePage
    {
        protected WebDriverExtensions dExt;

        public BasePage()
        {
            dExt = new WebDriverExtensions();
        }
        
        public void AcessarPaginaInicial()
        {
            dExt.LoadPage("https://srbarriga.herokuapp.com");
        }


        public string GetSuccessAlertText()
        {
            return dExt.GetText(By.XPath("//div[@class='alert alert-success']"));
        }

        public string GetDangerAlertText()
        {
            return dExt.GetText(By.XPath("//div[@class='alert alert-danger']"));
        }

    }

}
