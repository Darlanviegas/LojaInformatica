using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Admin : Usuario
    {
        private string CNPJ { get; set; }

        public Admin(string nome, string email,string senha,string cnpj): base(nome,email,senha)
        {
            SetCNPJ(cnpj);    

        }

        public string GetCNPJ()
        {
            return CNPJ;
        }
        public void SetCNPJ(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}
