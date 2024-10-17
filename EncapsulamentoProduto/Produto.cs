using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        // Declaração dos atributos
        private string nome;
        private double preco;
        private int qntd;

        // Declaração dos sets e gets (métodos do encapsulamento)
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome.ToUpper(); }
        }

        public double Preco
        {
            set { this.preco = value; }
            get { return this.preco; }
        }

        public int Qntd
        {
            set 
            {
                if (value > 0)
                    this.qntd = value;
                else
                    System.Console.WriteLine("Digite uma quantidade válida!");
            }
            get { return this.qntd; }
        }
        

        


        // Declaração dos métodos
        public void MostrarDados()
        {
            System.Console.WriteLine($"Nome: {Nome}\n" +
            $"Preço: {Preco:c}\n" +
            $"Quantidade: {Qntd}");
        }

        public void AdicionarProduto(int qntd)
        {
            this.qntd += qntd;
            System.Console.WriteLine($"{qntd} produto(s) foram adicionado(s).");
            MostrarDados();
        }

        public void RemoverProduto(int qntd)
        {
            this.qntd -= qntd;
            System.Console.WriteLine($"{qntd} produto(s) foram removido(s).");
            MostrarDados();
        }

        public double ValorTotalEstoque() => preco * qntd;
    }
}