using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteMouse
    {
        [Fact]
        public void MouseDeveTerNomeValidoCadastrado()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetNome("G502");
            //Assert
            Assert.Equal("G502", mouse.GetNome());
        }
        [Fact]
        public void MouseDeveTerMarcaValidaCadastrada()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetMarca("G502");
            //Assert
            Assert.Equal("G502", mouse.GetMarca());
        }
        [Fact]
        public void MouseDeveTerDescricaoValidaCadastrada()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetDescricao("Melhor mouse do Brasil");
            //Assert
            Assert.Equal("Melhor mouse do Brasil", mouse.GetDescricao());
        }
        [Fact]
        public void MouseDeveTerValorValidoCadastrado()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetValor(750);
            //Assert
            Assert.Equal(750, mouse.GetValor());
        }
        [Fact]
        public void MouseDeveTerEstoqueValidoCadastrado()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetEstoque(25);
            //Assert
            Assert.Equal(25, mouse.GetEstoque());
        }
        [Fact]
        public void MouseDeveTerDPIValidaCadastrada()
        {  //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetDPI(50);
            //Assert
            Assert.Equal(50, mouse.GetDPI());
        }
        [Fact]
        public void MouseDeveTerConexaoValidaCadastrada()
        {   //Arrange
            Mouse mouse = new Mouse("G502", "Logitech", "Melhor mouse do brasil", 750, 25, 50, true);
            //Act
            mouse.SetSemFio(true);
            //Assert
            Assert.Equal(true, mouse.GetSemFio());
        }
    }
}
