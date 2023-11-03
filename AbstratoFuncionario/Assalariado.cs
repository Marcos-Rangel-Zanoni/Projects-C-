using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    class Assalariado : Funcionario
    {
        public override double CalcularSalario(int diasUteis)
        {
            return salario * 30 / diasUteis;
        }
        public Assalariado(int codigo, string nome, 
            double salario) : base(codigo, nome, salario)
        {

        }
    }
}
