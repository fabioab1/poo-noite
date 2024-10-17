using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        private double chequeEspecial;
        private int numero;
        private string titular;
        private static int contadorCc;

        static ContaCorrente()
        {
            contadorCc = 110000;
        }

        public double Saldo{
            set{
                this.saldo = value;
            }
            get{
                return this.saldo;
            }
        }

        public double ChequeEspecial{
            set{
                this.chequeEspecial = value;
            }
            get{
                return this.chequeEspecial;
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

        public ContaCorrente(string nome)
        {
            Saldo = 0;
            ChequeEspecial = 300;
            Numero = contadorCc;
            contadorCc++;
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

        public void GerarExtrato()
        {
            Console.WriteLine($"Correntista: {Titular}");
            Console.WriteLine($"Nº da conta: {Numero}");
            Console.WriteLine($"Saldo: {Saldo:c}");
            Console.WriteLine($"Cheque Especial: {ChequeEspecial:c}");
        }
    }
}