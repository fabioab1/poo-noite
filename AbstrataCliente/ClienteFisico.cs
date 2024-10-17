using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        private string rg;

        public string Rg{
            set{
                this.rg = value;
            }
            get{
                return this.rg;
            }
        }

        public ClienteFisico(int codigo, string nome, int idade, string rg) : base (codigo, nome, idade)
        {
            Rg = rg;
            MostrarAtributos();
        }

        public override void VerificaIdade()
        {
            if (Idade >= 18 && Idade <= 45)
                Console.WriteLine("Cliente Físico");
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("RG: " + Rg);
        }
    }
}