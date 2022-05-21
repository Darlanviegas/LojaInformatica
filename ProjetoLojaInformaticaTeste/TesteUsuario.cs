using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TesteUsuario
    {
        [Fact]
        public void UsuarioDeveTerNomeValidoCadastrado()
        {   //Arrange
            Usuario usuario = new Usuario("João", "joão@gmail.com", "joão1234");
            //Act
            usuario.SetNome("Pedro");
            //Assert
            Assert.Equal("Pedro", usuario.GetNome());
        }
        [Fact]
        public void UsuarioDeveTerEmailValidoCadastrado()
        {   //Arrange
            Usuario usuario = new Usuario("João", "joão@gmail.com", "joão1234");
            //Act
            usuario.SetEmail("Pedro@gmail.com");
            //Assert
            Assert.Equal("Pedro@gmail.com", usuario.GetEmail());
        }
        [Fact]
        public void UsuarioDeveTerSenhalValidaCadastrada()
        {   //Arrange
            Usuario usuario = new Usuario("João", "joão@gmail.com", "joão1234");
            //Act
            usuario.SetSenha("Pedro2564%$#@&");
            //Assert
            Assert.Equal("Pedro2564%$#@&", usuario.GetSenha());
        }
    }
}
