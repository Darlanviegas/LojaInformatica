using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteCliente
    {
        [Fact]
        public void ClienteDeveTerNomeValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Carlos", "Carlos@gmail.com", "Carlos1234", "56252112552","Rua João Pessoa 45");
            //Act
            cliente.SetNome("Carlos");
            //Assert
            Assert.Equal("Carlos", cliente.GetNome());
        }
        [Fact]
        public void ClienteDeveTerEmailValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Carlos", "Carlos@gmail.com", "Carlos1234", "56252112552", "Rua João Pessoa 45");
            //Act
            cliente.SetEmail("Carlos");
            //Assert
            Assert.Equal("Carlos", cliente.GetEmail());
        }
        [Fact]
        public void ClienteDeveTerSenhalValidaCadastrada()
        {   //Arrange
            Cliente cliente = new Cliente("Carlos", "Carlos@gmail.com", "Carlos1234", "56252112552", "Rua João Pessoa 45");
            //Act
            cliente.SetSenha("Carlos");
            //Assert
            Assert.Equal("Carlos", cliente.GetSenha());
        }
        [Fact]
        public void ClienteDeveTerCPFValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Carlos", "Carlos@gmail.com", "Carlos1234", "56252112552", "Rua João Pessoa 45");
            //Act
            cliente.SetCPF("02715083026");
            //Assert
            Assert.Equal("02715083026", cliente.GetCPF());
        }
        [Fact]
        public void ClienteDeveTerEnderecoValidoCadastrado()
        {   //Arrange
            Cliente cliente = new Cliente("Carlos", "Carlos@gmail.com", "Carlos1234", "56252112552", "Rua João Pessoa 45");
            //Act
            cliente.SetEndereco("Rua Araucária 58");
            //Assert
            Assert.Equal("Rua Araucária 58", cliente.GetEndereco());
        }
    }
}
