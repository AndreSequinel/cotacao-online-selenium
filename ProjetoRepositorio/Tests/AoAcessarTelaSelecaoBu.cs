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
    internal class AoAcessarTelaSelecaoBu : TestFixture
    {

        public void Setup(TestFixture fixture)
        {
            fixture.driver = driver;
        }

        [Test]
        public void SelecionarBuELogar()
        {
            var tela_login_dansales_Po = new tela_login_dansales_PO(driver);
            var tela_selecao_bu_Po = new tela_selecao_bu_PO(driver);

            tela_login_dansales_Po.NavegarParaUrl();
            tela_login_dansales_Po.PreencherDadosTelaDeLogin();
            tela_login_dansales_Po.EfetuarAcaoDeLogin();

            tela_selecao_bu_Po.SelecionarBu2400();
            tela_selecao_bu_Po.EntrarAposSelecionarBu();
        }
    }
}
