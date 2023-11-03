using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario f = new Funcionario(1,"Ana",100);
            Assalariado a1 = new Assalariado(2, "Bia", 200);
            Assalariado a2 = new Assalariado(3, "Lia", 300);
            Comissionado c1 = new Comissionado(4, "Clara", 400,0.2);
            Comissionado c2 = new Comissionado(5, "Cléo", 500, 0.3);

            Departamento d1 = new Departamento(1, "TI");
            d1.Vetf = new List<Funcionario>();
            d1.Admitir(a1);
            d1.Admitir(c1);
            d1.Listar();
            Console.WriteLine("Total: "+ d1.CalculaFolha(30));
            d1.Demitir(2);
            d1.Listar();

            Departamento d2 = new Departamento(2, "RH");
            d2.Vetf = new List<Funcionario>();
            d2.Admitir(a2);
            d2.Admitir(c2);
            d2.Listar();
            Console.WriteLine("Total: " + d2.CalculaFolha(30));            
            d2.Demitir(5);
            d2.Listar();
            Console.ReadKey();
        }
    }
}
