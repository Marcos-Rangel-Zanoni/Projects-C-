using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    class Diretor : Funcionario, IAutenticavel
    {

        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Diretor validado");
                return true;
            }
            return false;
        }
    }
}
