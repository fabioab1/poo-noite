using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        private string nome;
        private int rg;

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }
        public int Rg{
            set{
                this.rg = value;
            }
            get{
                return this.rg;
            }
        }

        public Cliente()
        {
            
        }

        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }
    }
}