using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaGabriela = new ContaCorrente();
            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.numero = 863452;

            ContaCorrente ContaDaGabrielaCosta = new ContaCorrente();
            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (ContaDaGabriela == ContaDaGabrielaCosta));
            int idade = 27;
            int idade2 = 27;
            Console.WriteLine("Igualdade de tipo de valor: "+(idade == idade2));

            ContaDaGabriela = ContaDaGabrielaCosta;
            Console.WriteLine(ContaDaGabriela == ContaDaGabrielaCosta);

            ContaDaGabriela.saldo = 300;
            Console.WriteLine(ContaDaGabriela.saldo);
            Console.WriteLine(ContaDaGabrielaCosta.saldo);

            
            




            Console.ReadLine();


        }
    }
}
