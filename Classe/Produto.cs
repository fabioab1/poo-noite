using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        
        public string PrecoFormatado()
        {
            return preco.ToString("0.00");
        }

        public void VisualizarDados()
        {
            Console.WriteLine($"Código: {codigo}\n" + 
            $"Nome: {nome}\n" + 
            $"Preço: R$ {PrecoFormatado()}");
        }
    }
}