using FluentAssertions;
using RestSharp;
using System;
using Xunit;

namespace TestAutomationApi.NetCore2
{
    public class UnitTest1
    {
        private IRestResponse GetCEP(object CEP)
        {
            var client = new RestClient("https://viacep.com.br/ws/" + CEP + "/json/");
            var RSrequest = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };

            return client.Execute(RSrequest);
        }
        [Fact]
        public void Test1()
        {
            var response = GetCEP("89221515");
            //response.StatusCode.Should().Be(200);
            Assert.Contains("Rua Iririú", response.Content);

        }
    }
}
