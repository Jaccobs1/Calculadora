using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public  class Livro
    {
        private const int QUANTIDADE_PAGINAS = 384;
        private int _PaginaAtual = 0;

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int QuantidadePaginas { get; private set; }

        public Livro(string titulo, string autor, int quantidadePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            QuantidadePaginas = quantidadePaginas;
        }

        public int Ler()
        {
            _PaginaAtual++;
            return _PaginaAtual;
        }
    }
}
