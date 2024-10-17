using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;
        private int numero;
        private string titular;
        private static int contadorPp;

        static Poupanca()
        {
            contadorPp = 220000;
        }

        public double Saldo{
            set{
                this.saldo = value;
            }
            get{
                return this.saldo;
            }
        }

        public int Numero{
            set{
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }

        public string Titular{
            set{
                this.titular = value;
            }
            get{
                return this.titular;
            }
        }

        public Poupanca(string nome)
        {
            Saldo = 0;
            Numero = contadorPp;
            contadorPp++;
            Titular = nome;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {Saldo:c} realizado.");
            }
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        public void GerarRendimento()
        {
            Console.WriteLine($"Poupança: {Titular}");
            Console.WriteLine($"Nº da conta: {Numero}");
            Console.WriteLine($"Saldo: {Saldo:c}");
            Console.WriteLine($"Remuneração de 0,5% ao mês");
            Console.WriteLine($"Rendimento: {(Saldo * 0.5 / 100):c}");
        }
    }
}