using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationSrBarriga.NetCore2.Pages
{
    class ContasPage : BasePage
    {
        public void SetNome(string nome)
        {
            dExt.SetText("nome", nome);
        }
        public void Salvar()
        {
            dExt.Click(By.XPath("//button[.='Salvar']"));
        }
    }
}
