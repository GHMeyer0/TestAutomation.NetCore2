using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text; 

namespace TestAutomationWeb.NetCore2.Utils
{
    static class Configuration
    {
        private static IConfiguration _configuration;
        public static bool CLOSE_BROWSER = true;
        static Configuration()
        {
            var builder = new ConfigurationBuilder()
                                .AddJsonFile($"appsettings.json");

            _configuration = builder.Build();

        }
        public static Browser GetBrowser()
        {
           
            if (_configuration.GetSection("BrowserConfig:Browser").Value == "Firefox")
            {
                return Browser.Firefox;
            }
            if (_configuration.GetSection("BrowserConfig:Browser").Value == "Edge")
            {
                return Browser.Edge;
            }
            if (_configuration.GetSection("BrowserConfig:Browser").Value == "IE")
            {
                return Browser.InternetExplorer;
            }
            return Browser.Chrome;
            
        }
        public static bool IsHeadless()
        {
            if (_configuration.GetSection("BrowserConfig:Headless").Value == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }

    }
}
