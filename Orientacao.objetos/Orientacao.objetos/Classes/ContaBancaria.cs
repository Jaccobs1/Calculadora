using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.Classes
{
    public class ContaBancaria
    {
        private static int _Contador = 0;
        private static decimal _SaldoTotal = 0;

        public static int Contador { get => _Contador; }
        public static decimal SaldoTotal { get => _SaldoTotal; }

        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }


        public ContaBancaria(string titular)
        {
            Titular = titular;
            _Contador++;
        }
        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            _Contador++;
            _SaldoTotal += saldo;
        }

        public decimal Depositar(decimal valor)
        {
            return Saldo += valor;
        }

        public decimal Sacar(decimal valor)
        {
            return Saldo -= valor;
        }

        public decimal ExibirSaldo()
        {
            return Saldo;
        }
    }
}