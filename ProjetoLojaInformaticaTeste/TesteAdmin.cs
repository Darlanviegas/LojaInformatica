using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteAdmin
    {
        [Fact]
        public void AdminDeveTerNomeValidoCadastrado()
        {   //Arrange
            Admin admin = new Admin("João","joão@gmail.com","joão1234","12552112552");
            //Act
            admin.SetNome("Pedro");
            //Assert
            Assert.Equal("Pedro", admin.GetNome());
        }
        [Fact]
        public void AdminDeveTerEmailValidoCadastrado()
        {   //Arrange
            Admin admin = new Admin("João", "joão@gmail.com", "joão1234", "12552112552");
            //Act
            admin.SetEmail("joão2502@gmail.com");
            //Assert
            Assert.Equal("joão2502@gmail.com", admin.GetEmail());
        }
        [Fact]
        public void AdminDeveTerSenhalValidaCadastrada()
        {   //Arrange
            Admin admin = new Admin("João", "joão@gmail.com", "joão1234", "12552112552");
            //Act
            admin.SetSenha("joão@%$*&1234");
            //Assert
            Assert.Equal("joão@%$*&1234", admin.GetSenha());
        }
        [Fact]
        public void AdminDeveTerCNPJValidoCadastrado()
        {   //Arrange
            Admin admin = new Admin("João", "joão@gmail.com", "joão1234", "12552112552");
            //Act
            admin.SetCNPJ("08542375623");
            //Assert
            Assert.Equal("08542375623", admin.GetCNPJ());
        }

    }
}
