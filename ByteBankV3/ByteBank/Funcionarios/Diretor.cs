using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel //"O diretor é um funcionário"
    {
        public string Senha { get; set; }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor: ");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        public override double GetBonificacao()
        {
                
            return Salario * 0.5;
        }
    }
}
