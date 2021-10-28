using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo antes do saque: "+contaDoBruno.saldo);
            bool resultadoSaque =  contaDoBruno.Sacar(500);
            Console.WriteLine("Saldo depois do saque: "+contaDoBruno.saldo);
            Console.WriteLine("Resultado saque booleano: "+ resultadoSaque);

            contaDoBruno.Depositar(500); //função ou método depositar
            Console.WriteLine("Saldo depois de Depositar: "+ contaDoBruno.saldo);


            ContaCorrente contaDagabriela = new ContaCorrente();
            contaDagabriela.titular = "Gabriela";

            bool resultadoTRansferencia = contaDoBruno.Transferir(200, contaDagabriela);
            Console.WriteLine("Saldo depois da transferencia, Bruno: "+contaDoBruno.saldo);
            Console.WriteLine("Saldo depois da transferencia, Gabriela: " + contaDagabriela.saldo);
            Console.WriteLine("resultado transferencia: "+resultadoTRansferencia);

            Console.WriteLine("-------------------------------------");
            contaDagabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Saldo depois da transferencia, Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo depois da transferencia, Gabriela: " + contaDagabriela.saldo);
            Console.WriteLine("resultado transferencia: " + resultadoTRansferencia);




            Console.ReadLine();
        }
    }
}
