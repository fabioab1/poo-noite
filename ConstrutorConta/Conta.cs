using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string titular;
        private double saldo;
        private static int contador;
        public static int Contador{
            get{ return contador;}
        }

        public Conta()
        {
            contador++;
            // Construtor padrão
        }

        public Conta(int numero)
        {
            this.numero = numero;
            contador++;
        }

        public Conta(int numero, string nome)
        {
            this.numero = numero;
            this.titular = nome;
            contador++;
        }

        public Conta(int numero, string nome, double saldo)
        {
            this.numero = numero;
            this.titular = nome;
            this.saldo = saldo;
            contador++;
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