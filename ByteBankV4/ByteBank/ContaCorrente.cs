﻿using System;


namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

       
        public int Numero { get; }
            
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTRansferenciasNãoPermitidas { get; private set; }

        public int _agencia;
        public int Agencia { get; }
        

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
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0 )
            {
                throw new ArgumentException("O argumento agência deve ser maior que 0",nameof(agencia));
    
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento deve ser maior que 0.",nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }

        public bool Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof (valor));
            }


            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;

                throw new SaldoInsuficienteException(Saldo, valor);    
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {

                ContadorTRansferenciasNãoPermitidas++;
                throw new SaldoInsuficienteException("Operação não realizada.");
                
            }


            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }
    }
}
