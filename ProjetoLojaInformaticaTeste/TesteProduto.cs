using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteProduto
    {
        [Fact]
        public void ProdutoDeveTerNomeValidoCadastrado()
        {   //Arrange            
            Produto produto = new Produto("Teclado", "Intelbras", "O melhor produto do Brasil", 200,10);
            //Act            
            produto.SetNome("Teclado");
            //Assert
            Assert.Equal("Teclado", produto.GetNome());
        }
        [Fact]
        public void ProdutoDeveTerMarcaValidaCadastrada()
        {   //Arrange            
            Produto produto = new Produto("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10);
            //Act            
            produto.SetMarca("Positivo");
            //Assert
            Assert.Equal("Positivo", produto.GetMarca());
        }
        [Fact]
        public void ProdutoDeveTerDescricaoValidaCadastrada()
        {   //Arrange            
            Produto produto = new Produto("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10);
            //Act            
            produto.SetDescricao("O melhor do mundo");
            //Assert
            Assert.Equal("O melhor do mundo", produto.GetDescricao());
        }
        [Fact]
        public void ProdutoDeveTerValorValidoCadastrado()
        {   //Arrange            
            Produto produto = new Produto("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10);
            //Act            
            produto.SetValor(250);
            //Assert
            Assert.Equal(250, produto.GetValor());
        }
        [Fact]
        public void ProdutoDeveTerEstoqueValidoCadastrado()
        {   //Arrange            
            Produto produto = new Produto("Teclado", "Intelbras", "O melhor produto do Brasil", 200, 10);
            //Act            
            produto.SetEstoque(25);
            //Assert
            Assert.Equal(25, produto.GetEstoque());
        }
    }
}
