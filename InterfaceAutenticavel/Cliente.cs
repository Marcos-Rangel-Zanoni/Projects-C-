using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    class Cliente : IAutenticavel
    {
        private int senha;
        public int Senha
        {
            set {this.senha = value;  }
            get { return this.senha; }
        }

        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente validado");
                return true;
            }
            return false;
        }
    }
}
