using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Teclado : Produto
    {
        private bool SemFio { get; set; }
        private bool Mecanico { get; set; }

        public Teclado(string nome, string marca, string descricao, double valor, int estoque, bool semfio, bool mecanico) : base(nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semfio);
            SetMecanico(mecanico);
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
        public bool GetMecanico()
        {
            return Mecanico;
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
    }
}
