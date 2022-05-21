using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteTeclado
    {
        public class TesteProduto
        {
            [Fact]
            public void TecladoDeveTerNomeValidoCadastrado()
            {   //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetNome("Teclado");
                //Assert
                Assert.Equal("Teclado", teclado.GetNome());
            }
            [Fact]
            public void TecladoDeveTerMarcaValidaCadastrada()
            {   //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetMarca("Logitech");
                //Assert
                Assert.Equal("Logitech", teclado.GetMarca());
            }
            [Fact]
            public void TecladoDeveTerDescricaoValidaCadastrada()
            {   //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetDescricao("Teclado");
                //Assert
                Assert.Equal("Teclado", teclado.GetDescricao());
            }
            [Fact]
            public void TecladoDeveTerValorValidoCadastrado()
            {  //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetValor(300);
                //Assert
                Assert.Equal(300, teclado.GetValor());
            }
            [Fact]
            public void TecladoDeveTerEstoqueValidoCadastrado()
            {  //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetEstoque(12);
                //Assert
                Assert.Equal(12, teclado.GetEstoque());
            }
            [Fact]
            public void TecladoDeveTerConexaoValidaCadastrada()
            {  //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetSemFio(true);
                //Assert
                Assert.Equal(true, teclado.GetSemFio());
            }
            [Fact]
            public void TecladoDeveTerTipoValidoCadastrado()
            {  //Arrange            
                Teclado teclado = new Teclado("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10, true, true);
                //Act            
                teclado.SetMecanico(false);
                //Assert
                Assert.Equal(false, teclado.GetMecanico());
            }

        }
    }
}

