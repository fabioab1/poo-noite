using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        private string nome;

        public double Verba{
            set{
                this.verba = value;
            }
            get{
                return this.verba;
            }
        }

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
            set { this.nome = value;}
        }

        public Comprador(double valor, string nome)
        {
            Verba = valor;
            Nome = nome;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {Nome}\tVerba: {Verba:c}");
        }
    }
}