using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(514, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 456478);

                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("|Argumento com problema: "+ ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);

                Console.WriteLine(ex.StackTrace);

                
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo saldo insuficente exception");
            }
            catch(Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

            try
            {
                Metodo();
            }
            
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
           

            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
           
            
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com um número+ "+ numero+" e divisor"+divisor);
                throw;
                Console.WriteLine("Código depois do throw");


            }

            //return numero / divisor;


        }
    }
}
