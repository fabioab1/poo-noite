using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private static int contador;

        static Produto()
        {
            contador = 500;
        }

        public int Codigo{
            set{
                this.codigo = value;
            }
            get{
                return this.codigo;
            }
        }

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }

        public double Preco{
            set{
                this.preco = value;
            }
            get{
                return this.preco;
            }
        }

        public Produto(string nome, double preco)
        {
            Codigo = contador;
            Nome = nome;
            Preco = preco;
            contador++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco:c}");
        }
    }
}