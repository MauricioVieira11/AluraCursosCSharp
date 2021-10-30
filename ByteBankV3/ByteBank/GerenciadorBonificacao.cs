using ByteBank.Funcionarios;

namespace ByteBank
{
      class GerenciadorBonificacao
    {
        private static double _totalBonificacao;

        public static void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
