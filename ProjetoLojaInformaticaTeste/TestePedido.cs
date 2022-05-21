using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProjetoLojaInformatica;

namespace ProjetoLojaInformaticaTeste
{
    public class TestePedido
    {
        [Fact]
        public void PedidoDeveTerUsuarioValidoCadastrado()
        {   //Arrange
            var usuarioteste = new Usuario("Joaquim", "joaquim@gmail.com", "Joaquim&*%$@5214");
            Pedido pedido = new Pedido(usuarioteste, 5000, "Entregue", DateTime.Parse("30/04/2020"));
            //Act            
            pedido.SetUsuario(usuarioteste);
            //Assert
            Assert.Equal(usuarioteste, pedido.GetUsuario());
        }
        [Fact]
        public void PedidoDeveTerValorTotalValidoCadastrado()
        {   //Arrange
            var usuarioteste = new Usuario("Joaquim", "joaquim@gmail.com", "Joaquim&*%$@5214");
            Pedido pedido = new Pedido(usuarioteste, 5000, "Entregue", DateTime.Parse("30/04/2020"));
            //Act
            pedido.SetValorTotal(20000);
            //Assert
            Assert.Equal(20000, pedido.GetValorTotal());
        }
        [Fact]
        public void PedidoDeveTerStatusValidoCadastrado()
        {   //Arrange
            var usuarioteste = new Usuario("Joaquim", "joaquim@gmail.com", "Joaquim&*%$@5214");
            Pedido pedido = new Pedido(usuarioteste, 5000, "Entregue", DateTime.Parse("30/04/2020"));
            //Act
            pedido.SetStatus("Pendente");
            //Assert
            Assert.Equal("Pendente", pedido.GetStatus());
        }
        [Fact]
        public void PedidoDeveTerDataDeEntregaValidaCadastrada()
        {   //Arrange
            var usuarioteste = new Usuario("Joaquim", "joaquim@gmail.com", "Joaquim&*%$@5214");
            Pedido pedido = new Pedido(usuarioteste, 5000, "Entregue", DateTime.Parse("30/04/2020"));
            //Act
            pedido.SetData(DateTime.Parse("30/04/2020"));
            //Assert
            Assert.Equal(DateTime.Parse("30/04/2020"), pedido.GetData());
        }
       
    }
}
