using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    class Dependente
    {
        private int codigo;
        private string nome;
        private int idade;

        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome:" + Nome + "\tIdade: " + Idade);
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public bool verificarMaiorIdade()
        {
            if (Idade > 18)
                return true;
            return false;
        }
    }
}
