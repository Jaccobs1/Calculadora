using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissaoEspacial.Entities
{
    public class Missao
    {
        public string Nome { get; set; }
        public int DiasDuracao { get; set; }
        public List<Astronauta> Astronautas { get; set; }

        public Missao(string nome, int diasDuracao, List<Astronauta> astronautas)
        {
            Nome = nome;
            DiasDuracao = diasDuracao;
            Astronautas = astronautas;
        }
    }
}
