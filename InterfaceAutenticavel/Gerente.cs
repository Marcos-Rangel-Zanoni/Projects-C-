using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    class Gerente : Funcionario , IAutenticavel
    {
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Gerente validado");
                return true;
            }
            return false;
        }
    }
}
