using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using ProjetoRepositorio.Fixture;
using ProjetoRepositorio.PageObjects;

namespace ProjetoRepositorio.Tests;

public class BuscandoInforma��es : TestFixture
{

    public void Setup(TestFixture fixture)
    {
        driver = fixture.driver;
    }

    [Test, Order(1)]
    public void ProcurarValorDolar()
    {
        //TEST WORKFLOW
        var InfoPesquisaPo = new InformacoesPesquisaPO(driver);

        InfoPesquisaPo.NavegarParaUrl();
        InfoPesquisaPo.PreecherInformacoesPesquisaDolar();

        try
        {
            double valorDolar = double.Parse(InfoPesquisaPo.ValorDolarTexto);
            double ValorReferencia = 5.0;

            if (valorDolar > ValorReferencia)
            {
                Console.WriteLine($"O Dolar est� alto. Seu valor �: {InfoPesquisaPo.ValorDolarTexto}");
            }

            else
            {
                Console.WriteLine($"O dolar est� acess�vel. Seu valor �: {InfoPesquisaPo.ValorDolarTexto}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("N�o foi poss�vel realizar a cota��o do Dolar $");
        }
    }

    [Test, Order(2)]
    public void ProcurarValorEuro()
    {
        var infoPesquisaPo = new InformacoesPesquisaPO(driver);

        infoPesquisaPo.NavegarParaUrl();
        infoPesquisaPo.PreencherInformacoesPesquisaEuro();

        try
        {
            double valorEuro = double.Parse(infoPesquisaPo.ValorEuroTexto);
            double ValorReferencia = 5.0;

            if (valorEuro > ValorReferencia)
            {
                Console.WriteLine($"O Euro est� alto. Seu valor �: {infoPesquisaPo.ValorEuroTexto}");
            }

            else
            {
                Console.WriteLine($"O Euro est� acess�vel. Seu valor �: {infoPesquisaPo.ValorEuroTexto}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("N�o foi poss�vel realizar a cota��o do Euro $");
        }
    }
}