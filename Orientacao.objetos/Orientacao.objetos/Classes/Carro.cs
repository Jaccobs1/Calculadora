using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void Acelerar()
        {
            Console.WriteLine($"{Modelo}: Vrumm!");
        }

        public void Acelerar(int pedar)
        {
            if (pedar <= 5)
            {
                Console.WriteLine($"{Modelo}: Vrum!");
            }
            else if (pedar <= 100)
            {
                Acelerar();
            }
            else
            {
                Console.WriteLine($"{Modelo}: VRUUUUUUUMMMMM!!!");
            }
        }
    }
}
