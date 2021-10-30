using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario //abstract: "O funcionário é uma abstração e não deve ser diretamente instaniado"
    {
        //0 - funcionario, 1 - diretor, 2-  designer...
        
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando funcionário: ");

            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }


        public abstract void AumentarSalario();


        public abstract double GetBonificacao();
        
    }
}
