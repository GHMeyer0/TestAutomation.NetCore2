using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationSrBarriga.NetCore2.Pages;
using Xunit;

namespace TestAutomationSrBarriga.NetCore2.Tests
{
    public class LoginTest : BaseTest
    {
        LoginPage loginPage = new LoginPage();

        [Fact]
        public void LoginSuccessfully()
        {
            Assert.Equal("Bem vindo, Gabriel Helko Meyer!", loginPage.GetSuccessAlertText());
        }
    }
}
