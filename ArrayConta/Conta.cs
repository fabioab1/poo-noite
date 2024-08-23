using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public void sacar(double valor)
        {
            if (valor <= saldo)
                saldo -= valor;
            else
                System.Console.WriteLine("Saldo insuficiente.");

        }

        public void depositar(double valor)
        {
            saldo += valor;
            System.Console.WriteLine($"Foi depositado R$ {valor} na conta.");
        }

        public void Extrato()
        {
            Console.WriteLine($"Número: {numero}\n" + 
            $"Titular: {titular}\n" + 
            $"Saldo: {saldo:c}.");
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