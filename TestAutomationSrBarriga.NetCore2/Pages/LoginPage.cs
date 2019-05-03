using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationSrBarriga.NetCore2.Pages
{
    class LoginPage : BasePage
    {
        public void SetEmail(string email)
        {
            driverExtensions.SetText("email", email);
        }
        public void SetSenha(string psw)
        {
            driverExtensions.SetText("senha", psw);
        }
        public void Entrar()
        {
            driverExtensions.Click(By.XPath("//button[.='Entrar']"));
        }

        public void Logar(string email, string psw)
        {
            AcessarPaginaInicial();
            SetEmail(email);
            SetSenha(psw);
            Entrar();
        }
    }
}
