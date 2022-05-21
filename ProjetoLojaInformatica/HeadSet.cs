using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Headset : Produto
    {
        private bool SemFio { get; set; }
        private bool Surround { get; set; }

        public Headset(string nome, string marca, string descricao, double valor, int estoque,bool semfio,bool surround):base(nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semfio);
            SetSurround(surround);
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
        public bool GetSurround()
        {
            return Surround;
        }
        public void SetSurround(bool surround)
        {
           Surround = surround;
        }
    }
}
