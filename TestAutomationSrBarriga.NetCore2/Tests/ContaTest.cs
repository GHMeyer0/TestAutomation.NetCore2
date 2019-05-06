using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationSrBarriga.NetCore2.Pages;
using Xunit;

namespace TestAutomationSrBarriga.NetCore2.Tests
{
    public class ContaTest : BaseTest
    {
        readonly MenuPage menu = new MenuPage();
        readonly ContasPage contas = new ContasPage();

        [Fact]
        public void InserirConta()
        {
            menu.AcessarTelaInserirConta();
            contas.SetNome("Conta de Teste");
            contas.Salvar();
            Assert.Equal("Conta adicionada com sucesso!", contas.GetSuccessAlertText());

        }
    }
}
