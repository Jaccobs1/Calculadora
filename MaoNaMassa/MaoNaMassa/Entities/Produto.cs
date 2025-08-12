using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassa.Entities
{
    public class Produto
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarPreco(decimal preco)
        {
            if (this.ValidarPreco(preco))
            {
                Preco = preco;
            }
            else
            {
                Console.WriteLine("valor inválido!");
            }
        }

        public bool ValidarPreco(decimal preco)
        {
            if (preco > 0)
            {
                return false;
            }
            return true;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome : {Nome}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}
