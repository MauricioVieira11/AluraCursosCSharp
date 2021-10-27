using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresEtextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres e textos - Projeto 5");
            char primeiraLetra = 'a';
            Console.WriteLine("USando o char: "+primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("Casting com o char: "+primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Casting com cálculo: "+primeiraLetra);

            string titulo = "Cursos de tecnologia da alura " + 2021;
            Console.WriteLine("usando o string: " + titulo);

            string cursosProgramacao = @".Net  +
                - Java - +
                Javascript";
            Console.WriteLine("Quebra de string: "+cursosProgramacao);


            Console.ReadLine();

        }
    }
}
