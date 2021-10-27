using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");
            int idade = 30;
            int idadeMauricio = idade;
            Console.WriteLine("idade mauricio: "+idadeMauricio);
            idade = 20;
            Console.WriteLine("idade 2: "+idade); //idade alterada


            Console.ReadLine();
        }
    }
}
