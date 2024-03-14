using ProjetoRepositorio.Fixture;
using ProjetoRepositorio.PageObjects;
using TestesAutDansales.Tests;
using TestesAutDansales.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAutDansales.Tests
{
    public class AoAcessarTelaDePedidos : TestFixture
    {
        private tela_login_dansales_PO tela_login_dansales_Po;
        private tela_selecao_bu_PO tela_selecao_bu_Po;

        public AoAcessarTelaDePedidos()
        {
            tela_login_dansales_Po = new tela_login_dansales_PO(driver);
            tela_selecao_bu_Po = new tela_selecao_bu_PO(driver);
        }

        public void Setup(TestFixture fixture)
        {
            fixture.driver = driver;
        }

        [Test]
        public void AcessarTelaInclusaoPedidos()
        {
            tela_login_dansales_Po.NavegarParaUrl();
            tela_login_dansales_Po.PreencherDadosTelaDeLogin();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();

            tela_selecao_bu_Po.SelecionarBu2300();
            tela_selecao_bu_Po.EntrarAposSelecionarBu();

        }
    }
}
