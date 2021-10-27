using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - Condicionais! ");
            Console.WriteLine(  );
            int idadeMauricio = 16;
            int quantidadePessoas = 2;

            if (idadeMauricio >= 18)
            {
                Console.WriteLine("Maior de idade. Pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Não possui mais de 18 anos. Mas está acompanhado.Pode entrar.");
                }else
                {
                    Console.WriteLine("Não tem mais de 18 anos. Não pode entrar!");

                }
            }

        }
    }
}
