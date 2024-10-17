using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente // Superclasse
    {
        protected int codigo;
        protected string nome;

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

        public Cliente()
        {

        }

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Mostrar()
        {
            Console.WriteLine($"\nCódigo: {Codigo}\tNome: {Nome}");
        }
    }
}