

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        
        
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return; //quanto tiver um return sem nada, o método para de executar assim que é chamadao.
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(int agencia, int numero) //define como se cria o objeto COntaCorrente
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

        }


        public bool Sacar(double valor)//método ou função
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }

        }
        public void Depositar(double valor) //método ou função
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }



}
