using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAutenticavel ia = new IAutenticavel();
            Cliente c = new Cliente();
            c.Senha = 123;
            IAutenticavel ia = c;
            Console.WriteLine("Validou? "+ia.Autentica(123));
            Console.WriteLine("Validou? " + ia.Autentica(100));

            Gerente g = new Gerente();
            g.Senha = 111;
            ia = g;
            Console.WriteLine("Validou? " + ia.Autentica(111));

            Diretor d = new Diretor();
            d.Senha = 150;
            IAutenticavel ia2 = d;
            Console.WriteLine("Validou? " + ia2.Autentica(150));
            Console.ReadKey();
        }
    }
}
