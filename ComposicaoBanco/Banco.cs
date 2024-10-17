using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;
        private string nome;

        public List<Poupanca> Poups{
            set{
                this.poups = value;
            }
            get{
                return this.poups;
            }
        }

        public List<ContaCorrente> Contas{
            set{
                this.contas = value;
            }
            get{
                return this.contas;
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

        public Banco(string nome)
        {
            Poups = new List<Poupanca>();
            Contas = new List<ContaCorrente>();
            Nome = nome;
        }

        ~Banco(){
            Console.WriteLine("O banco faliu.");
        }
    }
}