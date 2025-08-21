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
            Console.WriteLine("-----SELELCIONE UM HEROI-----")
            Console.WriteLine()
            Console.WriteLine(DadosDoJogo.heroisdisponiveis.Nome)
            break

            
        }

    }
    
}