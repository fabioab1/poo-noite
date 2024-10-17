using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataExercicio
{
    public class Disco : Produto
    {
        private string artista, gravadora;

        public string Artista{
            set{
                this.artista = value;
            }
            get{
                return this.artista;
            }
        }

        public string Gravadora{
            set{
                this.gravadora = value;
            }
            get{
                return this.gravadora;
            }
        }

        public Disco(int codigo, double preco, string artista, string gravadora) : base (codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = Preco + preco;
        }

    }
}