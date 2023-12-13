using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using ProjetoRepositorio.Fixture;
using ProjetoRepositorio.PageObjects;

namespace ProjetoRepositorio
{
    public class BuscandoInformações : TestFixture
    {  

        public void Setup(TestFixture fixture)
        {
            driver = fixture.driver;                  
        }

        [Test]
        public void ProcurarValorDolar()
        {
            var InfoPesquisaPo = new InformacoesPesquisaPO(driver);

            InfoPesquisaPo.NavegarParaUrl();
            InfoPesquisaPo.PreecherInformacoesPesquisaDolar();
            

            if (double.TryParse(InfoPesquisaPo.ValorDolarTexto, out double ValorDolar2))
            {
                double ValorReferencia = 5.0;

                if (ValorDolar2 > ValorReferencia)
                {
                    Console.WriteLine("O Dolar está alto. Seu valor é: " + InfoPesquisaPo.ValorDolarTexto);
                }

                else
                {
                    Console.WriteLine("O dolar está acessível. Seu valor é: " + InfoPesquisaPo.ValorDolarTexto);

                }
            }

            Dispose();
        }

        [Test]
        public void ProcurarValorEuro()
        {
            var InfoPesquisaPO = new InformacoesPesquisaPO(driver);

            InfoPesquisaPO.NavegarParaUrl();
            InfoPesquisaPO.PreecherInformacoesPesquisaEuro();

            if (double.TryParse(InfoPesquisaPO.ValorEuroTexto, out double ValorEuro2))
            {
                double ValorReferencia = 5.0;

                if (ValorEuro2 > ValorReferencia)
                {
                    Console.WriteLine("O Euro está alto. Seu valor é: " + InfoPesquisaPO.ValorEuroTexto);
                }

                else
                {
                    Console.WriteLine("O Euro está acessível. Seu valor é: " + InfoPesquisaPO.ValorEuroTexto);
                }
            }

            Dispose();
        }

    }
}