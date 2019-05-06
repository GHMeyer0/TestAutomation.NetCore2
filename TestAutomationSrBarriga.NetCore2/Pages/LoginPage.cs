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
            dExt.SetText("email", email);
        }
        public void SetSenha(string psw)
        {
            dExt.SetText("senha", psw);
        }
        public void Entrar()
        {
            dExt.Click(By.XPath("//button[.='Entrar']"));
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
