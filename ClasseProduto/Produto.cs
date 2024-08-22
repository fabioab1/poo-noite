using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        // Declaração dos atributos
        public string nome;
        public double preco;
        public int qntd;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        // Declaração dos métodos
        public void MostrarDados()
        {
            System.Console.WriteLine($"Nome: {nome}\n" + 
            $"Preço: {preco:c}\n" + 
            $"Quantidade: {qntd}");
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