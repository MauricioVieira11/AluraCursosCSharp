﻿using System;
using ByteBank.Funcionarios;
using ByteBank;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();        
        }


        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            sistemaInterno.Logar(parceiro, "123");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorbonificacao = new GerenciadorBonificacao();


            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            GerenciadorBonificacao.Registrar(guilherme);
            GerenciadorBonificacao.Registrar(pedro);
            GerenciadorBonificacao.Registrar(roberta);
            GerenciadorBonificacao.Registrar(igor);
            GerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mÊs: "+gerenciadorbonificacao.GetTotalBonificacao());

        }
    }
}
