using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");
            int idade;
            idade = 34;
            Console.WriteLine("Minha idade é: "+idade);
            idade = 10 +14; //mudei os valores da variável idade
            Console.WriteLine("Minha idade é: "+ idade);

            idade = 10 + 4 * 2;
            Console.Write("MInha idade é: "+idade +"!");



            Console.ReadLine();
        }
    }
}
