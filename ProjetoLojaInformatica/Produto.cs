using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Produto
    {
        private string Nome { get; set; }
        private string Marca { get; set; }
        private string Descricao { get; set; }
        private double Valor { get; set; }
        private int Estoque { get; set; }

        public Produto (string nome,string marca, string descricao,double valor,int estoque)
        {
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetValor(valor);
            SetEstoque(estoque);

        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;  
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public int GetEstoque()
        {
            return Estoque;
        }
        public void SetEstoque(int estoque)
        {
            Estoque = estoque;
        }

    }
}
