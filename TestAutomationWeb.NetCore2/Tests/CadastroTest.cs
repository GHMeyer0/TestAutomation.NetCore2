using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationWeb.NetCore2.Pages;
using Xunit;
using static TestAutomationWeb.NetCore2.Utils.WebDriverFactory;

namespace TestAutomationWeb.NetCore2.Tests
{
    public class CadastroTest : BaseTest
    {
        private readonly CampoTreinamentoPage page;

        
        public CadastroTest()
            {
                GetDriver().Navigate().GoToUrl("file:///C:/Users/ghmey/Documents/GitHub/TestAutomation-Java/CursoSelenium/src/main/resources/componentes.html");
                page = new CampoTreinamentoPage();
            }

        [Fact]
        public void deveRealizarCadastroComSucesso()
            {
                page.SetNome("Wagner");
                page.SetSobrenome("Costa");
                page.SetSexoMasculino();
                page.SetComidaPizza();
                page.SetEscolaridade("Mestrado");
                //page.setEsporte("Natacao");
                page.Cadastrar();

                Assert.Equal("Cadastrado!", page.ObterResultadoCadastro());
                Assert.Equal("Wagner", page.ObterNomeCadastro());
                Assert.Equal("Costa", page.ObterSobrenomeCadastro());
                Assert.Equal("Masculino", page.ObterSexoCadastro());
                Assert.Equal("Pizza", page.ObterComidaCadastro());
                //Assert.Equal("mestrado", page.ObterEscolaridadeCadastro());
                //Assert.Equal("Natacao", page.ObterEsportesCadastro());
            }
    }
}
