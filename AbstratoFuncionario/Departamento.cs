using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    class Departamento
    {
        private int codigo;
        private string nome;
        private List<Funcionario> vetF;

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Admitir(Funcionario f)
        {
            Vetf.Add(f);
        }
        public void Demitir(int codigoExcluir)
        {
            for (int i = 0; i < Vetf.Count; i++)
            {
                Funcionario f = Vetf.ElementAt<Funcionario>(i);
                if (f.Codigo == codigoExcluir)
                    Vetf.Remove(f);
            }
        }
        public double CalculaFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < Vetf.Count; i++)
            {
                Funcionario f = Vetf.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void Listar()
        {
            foreach (Funcionario f in Vetf)
                f.Mostrar();
        }
        public void ListarSalarioAlterado()
        {
            foreach (Funcionario f in Vetf)
            {
                f.CalcularSalario(30);
                f.Mostrar();
            }
        }

        

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public List<Funcionario> Vetf
        {
            set { this.vetF = value; }
            get { return this.vetF; }
        }
    }
}
