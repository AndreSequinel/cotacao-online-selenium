using ProjetoRepositorio.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAutDansales.PageObjects;
using OpenQA.Selenium;
using ProjetoRepositorio.PageObjects;

namespace TestesAutDansales.Tests
{
    public class AoAcessarTelaDeLogin : TestFixture
    {
        public void Setup(TestFixture fixture)
        {
            fixture.driver = driver;
        }

        [Test]
        public void RealizarLogin()
        {            
            var tela_login_dansales_Po = new tela_login_dansales_PO(driver);

            //Arrange
            tela_login_dansales_Po.NavegarParaUrl();

            //Act
            tela_login_dansales_Po.PreencherDadosTelaDeLogin();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();

            //Assert
            Console.WriteLine("\nLogin realizado com sucesso");
        }

        [Test]
        public void TentarRealizarLoginEverificarCamposObrigatorios()
        {
            var tela_login_dansales_Po = new tela_login_dansales_PO(driver);

            tela_login_dansales_Po.NavegarParaUrl();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();

            Assert.IsTrue(driver.FindElement(By.Id("errorTxtUserName")).Displayed, "Campo USUARIO não está sendo marcado como obrigatorio");
            Assert.IsTrue(driver.FindElement(By.Id("errorTxtPassword")).Displayed, "Campo SENHA não está sendo marcado como obrigatorio");

            Console.WriteLine("Campos obrigatórios estão sendo exibidos corretamente");
        }

        [Test]
        public void RealizarLoginETentarAcessarCadastros()
        {
            var tela_login_dansales_Po = new tela_login_dansales_PO(driver);
            var tela_selecao_bu_Po = new tela_selecao_bu_PO(driver);

            //Arrange
            tela_login_dansales_Po.NavegarParaUrl();

            //Act
            tela_login_dansales_Po.PreencherDadosTelaDeLogin();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();
            tela_selecao_bu_Po.SelecionarBu2300();
            tela_selecao_bu_Po.EntrarAposSelecionarBu();
            tela_login_dansales_Po.AcoesAposLogar();

        }
    }
}
