using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{ //           Classe derivada : Classe base
    public class ClienteFisico : Cliente
    {
        private int cpf;
        private string rg;

        public int Cpf{
            set{
                this.cpf = value;
            }
            get{
                return this.cpf;
            }
        }

        public string Rg{
            set{
                this.rg = value;
            }
            get{
                return this.rg;
            }
        }

        public ClienteFisico() : base()
        {

        }

        public ClienteFisico(int codigo, string nome, int cpf, string rg) : base(codigo, nome)
        {
            Cpf = cpf;
            Rg = rg;
        }

        public ClienteFisico(int cpf, string rg)
        {
            Cpf = cpf;
            Rg = rg;
        }

        public void Mostrar()
        {
            base.Mostrar();// Apresenta o código e o nome
            Console.WriteLine("Rg: " + Rg + "\t\tCPF: " + Cpf);
        }
    }
}