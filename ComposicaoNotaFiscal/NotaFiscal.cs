using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        private int numeroNf;
        private string data;
        private List<ItemNotaFiscal> vetItens;

        public int NumeroNf{
            set{
                this.numeroNf = value;
            }
            get{
                return this.numeroNf;
            }
        }

        public string Data{
            set{
                this.data = value;
            }
            get{
                return this.data;
            }
        }

        public List<ItemNotaFiscal> VetItens{
            set{
                this.vetItens = value;
            }
            get{
                return this.vetItens;
            }
        }
        
        public NotaFiscal(int numeroNf, string data)
        {
            NumeroNf = numeroNf;
            Data = data;
            // A composição acontece agora, pois os objetos NotaFiscal e vetor de itens são
            // instanciados juntos, em linhas separadas, mas em uma AÇÃO SÓ.
            VetItens = new List<ItemNotaFiscal>();
        }

        ~NotaFiscal(){
            VetItens = null;
            Console.WriteLine("Destruir a nota fiscal.");
        }
    }
}