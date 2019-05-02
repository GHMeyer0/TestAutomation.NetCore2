using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationWeb.NetCore2.Utils;
using static TestAutomationWeb.NetCore2.Utils.WebDriverFactory;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions;
using Xunit.Sdk;

namespace TestAutomationWeb.NetCore2.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
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
