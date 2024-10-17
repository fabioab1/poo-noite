using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public void Sacar(double valor)
        {
            if (valor <= saldo)
                saldo -= valor;
            else
                System.Console.WriteLine("Saldo insuficiente.");

        }

        public void Depositar(double valor)
        {
            saldo += valor;
            System.Console.WriteLine($"Foi depositado R$ {valor} na conta.");
        }
        
        public void Transferir(Conta conta, double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                conta.saldo += valor;
            }
            else
                System.Console.WriteLine("Saldo insuficiente.");
        }
    }
}