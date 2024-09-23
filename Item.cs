using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_POO
{
    internal class Item
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Item(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Quantidade: {Quantidade}, Preço: R${Preco:F2}";
        }
    }
}
