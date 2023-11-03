using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    class Funcionario
    {
        private int senha;
        public int Senha
        {
            set { this.senha = value; }
            get { return this.senha; }
        }        
    }
}
