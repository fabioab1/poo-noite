using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        private string cnpj;

        public string Cnpj{
            set{
                this.cnpj = value;
            }
            get{
                return this.cnpj;
            }
        }

        public ClienteJuridico(int codigo, string nome, int idade, string cnpj) : base (codigo, nome, idade)
        {
            Cnpj = cnpj;
            MostrarAtributos();
        }

        public override void VerificaIdade()
        {
            if (Idade >= 46)
                Console.WriteLine("Cliente Jurídico");
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}