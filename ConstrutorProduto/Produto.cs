using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }

        // Criar 3 Construtores
        public Produto()
        {
            
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public Produto(int codigo, string nome, double preco, int qtde)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        // Criar o método MostrarAtributos()
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Quantidade: " + Qtde);
        }
    }
}