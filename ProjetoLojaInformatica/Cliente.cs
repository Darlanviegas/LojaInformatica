using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Cliente : Usuario
    {
        private string CPF { get; set; }
        private string Endereco { get; set; }

        public Cliente(string nome,string email, string senha,string cpf,string endereco):base(nome, email,senha)
        {
            SetEmail(email);
            SetEndereco(endereco);
        }

        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            CPF = cpf;  
        }

        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}
