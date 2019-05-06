using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationSrBarriga.NetCore2.Pages
{
    class MenuPage : BasePage
    {
        public void AcessarTelaInserirConta()
        {
            dExt.Click(By.LinkText("Contas"));
            dExt.Click(By.LinkText("Adicionar"));
        }
    }
}
