using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationWeb.NetCore2.Utils;

namespace TestAutomationWeb.NetCore2.Pages
{
    class BasePage
    {
        protected WebDriverExtensions driverExtensions;
    
        public BasePage()
        {
            driverExtensions = new WebDriverExtensions();
        }
    }

}
