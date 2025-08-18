using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora.Operações
{
    internal class Raiz
    {
        static public double Radiciacao(double radicando, double indice = 2)
        {
            //Inserir indíce=2 para raíz quadrada, 3 para raíz cúbica, etc.
            //Realiza raíz quadrada caso um indíce não seja mencionado.
            return(indice==2 ? Math.Sqrt(radicando) : Math.Pow(radicando, 1 / indice));

        }
    }
}
