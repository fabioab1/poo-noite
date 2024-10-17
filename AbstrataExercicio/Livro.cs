using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataExercicio
{
    public class Livro
    {
        private string autor;
        private long isbn;

        public string Autor{
            set{
                this.autor = value;
            }
            get{
                return this.autor;
            }
        }

        public long Isbn{
            set{
                this.isbn = value;
            }
            get{
                return this.isbn;
            }
        }

        public Livro(int codigo, double preco, string autor, long isbn) : base (codigo, preco)
        {
            Autor = autor;
            Isbn = isbn;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = Preco + preco;
        }
    }
}