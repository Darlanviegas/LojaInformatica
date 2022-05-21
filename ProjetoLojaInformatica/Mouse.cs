using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaInformatica
{
    public class Mouse : Produto
    {
        private int DPI { get; set; }
        private bool SemFio { get; set; }

        public Mouse(string nome, string marca, string descricao, double valor, int estoque, int dpi,bool semfio) : base(nome, marca, descricao, valor, estoque)
        {
            SetDPI(dpi);
            SetSemFio(semfio);
        }

        public int GetDPI()
        {
            return DPI;
        }
        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semfio)
        {
            SemFio = semfio;
        }
    }
}
