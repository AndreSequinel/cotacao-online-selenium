using ProjetoRepositorio.Fixture;
using ProjetoRepositorio.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAutDansales.PageObjects;

namespace TestesAutDansales.Tests
{
    internal class AoAcessaTelaLicitacoes : TestFixture
    {
        public void Setup(TestFixture fixture)
        {
            fixture.driver = driver;
        }

        [Test]
        public void AcessarCampoDeRelatorios()
        {
            var tela_login_dansales_Po = new tela_login_dansales_PO(driver);
            var tela_selecao_bu_Po = new tela_selecao_bu_PO(driver);
            var tela_licitacoes_dansales_Po =  new tela_licitacoes_dansales_PO(driver);

            //Arrange
            tela_login_dansales_Po.NavegarParaUrl();

            //Act
            tela_login_dansales_Po.PreencherDadosTelaDeLogin();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();
            tela_selecao_bu_Po.SelecionarBu2300();
            tela_selecao_bu_Po.EntrarAposSelecionarBu();

            tela_licitacoes_dansales_Po.AcessarRelatoriosEmLicitacoes();
        }
    }
}
