using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationWeb.NetCore2.Pages
{
    class CampoTreinamentoPage : BasePage
    {
        public void SetNome(String nome)
        {
            driverExtensions.SetText("elementosForm:nome", nome);
        }

        public void SetSobrenome(String sobrenome)
        {
            driverExtensions.SetText("elementosForm:sobrenome", sobrenome);
        }

        public void SetSexoMasculino()
        {
            driverExtensions.ClickRadio("elementosForm:sexo:0");
        }

        public void SetSexoFeminino()
        {
            driverExtensions.ClickRadio("elementosForm:sexo:1");
        }

        public void SetComidaCarne()
        {
            driverExtensions.ClickRadio("elementosForm:comidaFavorita:0");
        }

        public void SetComidaPizza()
        {
            driverExtensions.ClickRadio("elementosForm:comidaFavorita:2");
        }

        public void SetComidaVegetariano()
        {
            driverExtensions.ClickRadio("elementosForm:comidaFavorita:3");
        }

        public void SetEscolaridade(string valor)
        {
            driverExtensions.SelectCombo("elementosForm:escolaridade", valor);
        }

        //TODO: Ajustar
//        public void SetEsporte(string... valores)
//       {
//            for (String valor: valores)
//                driverExtensions.SelectCombo("elementosForm:esportes", valor);
//        }

        public void Cadastrar()
        {
            driverExtensions.Click("elementosForm:cadastrar");
        }

        public string ObterResultadoCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='resultado']/span"));
        }


        public string ObterNomeCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descNome']/span"));
        }

        public string ObterSobrenomeCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descSobrenome']/span"));
        }

        public string ObterSexoCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descSexo']/span"));
        }

        public string ObterComidaCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descComida']/span"));
        }

        public string ObterEscolaridadeCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descEscolaridade']/span"));
        }

        public string ObterEsportesCadastro()
        {
            return driverExtensions.GetText(By.XPath("//*[@id='descEsportes']/span"));
        }
    }
}
