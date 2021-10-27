using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12");

            double valorInvestido = 1000;
            double falorRendimento = 1.0036;

            for(int contadorAno = 1;contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1;contadorMes<=12;contadorMes++)
                {
                    valorInvestido *= falorRendimento;
                }
                falorRendimento += 1.0010;
            }
            Console.WriteLine("Ao término do investimento terá: "+valorInvestido);


            Console.ReadLine();

        }
    }
}
