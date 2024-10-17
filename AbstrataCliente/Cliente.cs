using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string nome;
        protected int idade;
        // protected List<Endereco> enderecos;

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

        public int Idade{
            set{
                this.idade = value;
            }
            get{
                return this.idade;
            }
        }

        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tIdade: {Idade}");
        }

        public abstract void VerificaIdade();
    }
}