using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteHeadSet
    {
        public class TesteCliente
        {
            [Fact]
            public void HeadsetDeveTerNomeValidoCadastrado()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10,true,true);
                //Act
                headset.SetNome("KrakenV3");
                //Assert
                Assert.Equal("KrakenV3", headset.GetNome());
            }
            [Fact]
            public void HeadsetDeveTerMarcaValidaCadastrada()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetMarca("Razer");
                //Assert
                Assert.Equal("Razer", headset.GetMarca());
            }
            [Fact]
            public void HeadsetDeveTerDescricaoValidaCadastrada()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetDescricao("O melhor do brasil");
                //Assert
                Assert.Equal("O melhor do brasil", headset.GetDescricao());
            }
            [Fact]
            public void HeadsetDeveTerValorValidoCadastrado()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetValor(600);
                //Assert
                Assert.Equal(600, headset.GetValor());
            }
            [Fact]
            public void HeadsetDeveTerEstoqueValidoCadastrado()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetEstoque(20);
                //Assert
                Assert.Equal(20, headset.GetEstoque());
            }
            [Fact]
            public void HeadsetDeveTerConexaoValidaCadastrada()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetSemFio(true);
                //Assert
                Assert.Equal(true, headset.GetSemFio());
            }
            [Fact]
            public void HeadsetDeveTerTipoDeSomValidoCadastrado()
            {   //Arrange
                Headset headset = new Headset("KrakenV3", "Razer", "O Razer Kraken vem construindo uma reputação de clássico cult na comunidade dos jogos", 500, 10, true, true);
                //Act
                headset.SetSurround(false);
                //Assert
                Assert.Equal(false, headset.GetSurround());
            }
        }
    }
}
