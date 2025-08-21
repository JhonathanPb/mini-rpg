using System;
using System.Collections.Generic;

namespace MiniRPG
{

    class Program
    {
        public static void Main(string[] args)
        {
            // Inicializar os dados do jogo
            DadosDoJogo.CarregadorDados();
            
            // Menu para exibir o número de heróis e inimigos disponíveis
            Console.WriteLine("-----SELELCIONE UM HEROI-----");
            Console.WriteLine();
            for (int h = 0; h < DadosDoJogo.heroisdisponiveis.Count; h++)
            {
                Heroi heroi = DadosDoJogo.heroisdisponiveis[h];
                Console.WriteLine($"{h + 1}. Nome: {heroi.Nome} - Classe: {heroi.Classe}");
            }

            // Escolha do Heroi de 1 a 4
            Console.WriteLine("\nEscolha um Heroi: ")
            string escolha = Console.ReadLine()


            
        }

    }
    
}