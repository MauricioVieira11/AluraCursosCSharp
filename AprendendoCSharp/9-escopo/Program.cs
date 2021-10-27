using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 - Escopo! ");
            Console.WriteLine();
            int idadeMauricio = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "joão está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João NÂO está acompanhado.";
            }

            if (idadeMauricio >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }

            else
            {
                Console.WriteLine("Não pode entrar!");

            }


        }
    }
}
