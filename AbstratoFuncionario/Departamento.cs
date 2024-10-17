using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        private int codigo;
        private string descricao;
        private List<Funcionario> vetF;

        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Codigo{
            set{
                this.codigo = value;
            }
            get{
                return this.codigo;
            }
        }

        public string Descricao{
            set{
                this.descricao = value;
            }
            get{
                return this.descricao;
            }
        }
        
        public List<Funcionario> VetF{
            set{
                this.vetF = value;
            }
            get{
                return this.vetF;
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tDescrição: {Descricao}");
        }

        public void Admitir(Funcionario funcionario)
        {
            VetF.Add(funcionario);
        }

        public void Listar()
        {
            MostrarAtributos();
            foreach(Funcionario f in VetF)
                f.MostrarAtributos();
        }

        public void Demitir(int codigo)
        {
            /* // Utilizando foreach
            Funcionario funcionarioDemitido = null;
            foreach(Funcionario f in VetF)
                if (f.Codigo == codigo)
                    funcionarioDemitido = f;
            
            VetF.Remove(funcionarioDemitido);
            */

            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}