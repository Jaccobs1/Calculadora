using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public int Idade { get; private set; }

        public int CalcularIdadeEmMeses(int idade)
        {
            return idade * 12;
        }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public Aluno(string nome, string matricula, int idade)
        {
            Nome = nome;
            Matricula = matricula;
            Idade = idade;
        }
    }
}
