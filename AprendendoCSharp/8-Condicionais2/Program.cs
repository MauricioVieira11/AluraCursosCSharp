using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - Condicionais 2! ");
            Console.WriteLine();
            int idadeMauricio = 18;
            // int quantidadePessoas = 2;

            // bool acompanhado = quantidadePessoas >=2;

            bool acompanhado = true;


            if (idadeMauricio >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }

            else
            {
                Console.WriteLine("Não pode entrar!");

            }



        }
    }

}