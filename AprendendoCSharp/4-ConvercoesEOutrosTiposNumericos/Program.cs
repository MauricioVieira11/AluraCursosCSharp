using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvercoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - COnverções e outros tipos numéricos");
            double salario;
            salario = 1200.50;

            int salarioInteiro;
            salarioInteiro = (int)salario; //casting
            Console.WriteLine("Meu salário é: "+salarioInteiro);

            //longvariável de 64 bits
            long idade;
            idade = 2500000000000000;
            Console.WriteLine("Idade com o long: "+idade);

            short quantidadeProdutos = 14000;
            Console.WriteLine("Exemplo short: " + quantidadeProdutos);

            float altura = 1.80f; //colocar o sufixo f para usar o float
            Console.WriteLine("ALtura com o float: " +altura);




            Console.ReadLine();
        
        }
    }
}
