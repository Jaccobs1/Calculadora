using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissaoEspacial.Entities
{
    public class Astronauta
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string PaisOrigem { get; private set; }

        public Astronauta(string nome, DateTime dataNascimento, string paisOrigem)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            PaisOrigem = paisOrigem;
        }

    }
}
