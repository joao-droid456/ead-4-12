using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _EAD__04_12_
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
    }
}
