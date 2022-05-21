using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Pedido
    {
        private Usuario Usuario { get; set; }
        private List<Produto>Produtos { get; set; }
        private double ValorTotal { get; set; }
        private string Status { get; set; }
        private DateTime Data { get; set; }

        public Pedido(Usuario usuario,double valortotal, string status, DateTime data)
        {
            SetUsuario(usuario);
            Produtos = new List<Produto>();
            SetValorTotal(valortotal);
            SetStatus(status);
            SetData(data);
            
        }

        public Usuario GetUsuario()
        {
            return Usuario;
        }
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
        public List<Produto> GetListaProdutos()
        {
            return Produtos;
        }
        public void SetListaProdutos(List<Produto> produto)
        {
            Produtos = produto;
        }
        public double GetValorTotal()
        {
            return ValorTotal;
        }
        public void SetValorTotal(double valortotal)
        {
            ValorTotal = valortotal;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
           Status = status;
        }
        public DateTime GetData()
        {
            return Data;
        }
        public void SetData(DateTime data)
        {
            Data = data;
        }
    }
}
