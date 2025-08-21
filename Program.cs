using System;
using System.Collections.Generic;
using System.Threading;

namespace MiniRPG
{

    class Program
    {
        public static void Main(string[] args)
        {
            // Inicializar os dados do jogo
            DadosDoJogo.CarregadorDados();

            Inimigo? inimigoSelecionado = null;
            Heroi? heroiSelecionado = null;
            bool escolhaInvalida = true;

            while (escolhaInvalida)
            {
                // Menu para exibir o número de heróis e inimigos disponíveis
                Console.WriteLine("-----SELELCIONE UM HEROI-----");
                Console.WriteLine();
                for (int h = 0; h < DadosDoJogo.heroisdisponiveis.Count; h++)
                {
                    Heroi heroi = DadosDoJogo.heroisdisponiveis[h];
                    Console.WriteLine($"{h + 1}. Nome: {heroi.Nome} - Classe: {heroi.Classe}");
                }

                // Escolha do Heroi de 1 a 4
                Console.WriteLine("\nEscolha um Heroi: ");
                string opcao = Console.ReadLine();
                int escolha;
                
                if (int.TryParse(opcao, out escolha) && escolha > 0 && escolha <= DadosDoJogo.heroisdisponiveis.Count)
                {
                    heroiSelecionado = DadosDoJogo.heroisdisponiveis[escolha - 1];
                    Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine($"Herois Escolhido: {heroiSelecionado!.Nome}");
                    escolhaInvalida = false;
                }
                else
                {
                    Console.WriteLine("\nEntrada Inválida. Digite APENAS NÚMEROS!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    escolhaInvalida = true;
                }
            
            } 

            // Selecionador de Inimigos (Base em Porcentagem)
            int sumTotChan = 0;

            foreach (var inimigo in DadosDoJogo.inimigosdisponiveis)
            {
                sumTotChan += inimigo.ChanceDeAparecer;
            }

            Random random = new Random();
            int numAleatorio = random.Next(sumTotChan);
            int acumlar = 0;

            foreach (var inimigo in DadosDoJogo.inimigosdisponiveis)
            {
                acumlar += inimigo.ChanceDeAparecer;

                if (numAleatorio < acumlar)
                {
                    inimigoSelecionado = inimigo;
                    break;
                }
            }

            Console.WriteLine($"\nInimigo: {inimigoSelecionado!.Nome}");
            Thread.Sleep(4000);

            // Batalha

        }

    }
    
}