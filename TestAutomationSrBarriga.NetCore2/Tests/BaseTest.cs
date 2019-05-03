using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationSrBarriga.NetCore2.Utils;
using static TestAutomationSrBarriga.NetCore2.Utils.WebDriverFactory;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using Xunit.Sdk;
using TestAutomationSrBarriga.NetCore2.Pages;

namespace TestAutomationSrBarriga.NetCore2.Tests
{
    public class BaseTest : IDisposable
    {
        private LoginPage loginPage = new LoginPage();
        public BaseTest()
        {
            loginPage.Logar("ghmeyer0@gmail.com", "teste");
        }
        public void Dispose()
        {
            if (Configuration.CLOSE_BROWSER)
            {
                KillDriver();
            }
        }
    }
}
