using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Conta
    {
        private int numero;
        private List<Cliente> titular; // Relacionamento entre classes por meio do atributo titular.
        private double saldo;

        public int Numero{
            set{
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }

        public List<Cliente> Titular{
            set{
                this.titular = value;
            }
            get{
                return this.titular;
            }
        }

        public double Saldo{
            set{
                this.saldo = value;
            }
            get{
                return this.saldo;
            }
        }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero + "\tSaldo: " + Saldo); // Cada classe cuida das suas informações, jamais misturá-las
        }
    }
}