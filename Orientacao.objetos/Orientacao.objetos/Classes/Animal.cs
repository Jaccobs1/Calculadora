using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public class Animal
    {
        public string Nome { get; set; }
        public string NomeCientifico { get; set; }
        public int Idade { get; set; }

        public void Movimentar(int velocidade)
        {
            if (velocidade <= 20 && velocidade > 0)
            {
                Console.WriteLine($"{Nome} está se movimentando lentamente!");
            }
            else if (velocidade <= 50)
            {
                Console.WriteLine($"{Nome} está se movimentando normalmente!");
            }
            else if (velocidade > 50)
            {
                Console.WriteLine($"{Nome} está se movimentando rapidamente!");
            }
            else
            {
                Console.WriteLine($"{Nome} está se movimentando para trás!");
            }
        }
    }
}
