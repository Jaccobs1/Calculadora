using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque =+ quantidade;
        }

        public static string CadastrarProduto(double preco, bool internacional)
        {
            if (internacional)
            {
                return $"${preco.ToString("F2")}";
            }
            else
            {
                return $"R${preco.ToString("F2")}";
            }
        }
    }
}
