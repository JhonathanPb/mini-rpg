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
            
            // Exibir o número de heróis e inimigos disponíveis
            Console.WriteLine($"O numero de Herois disponiveis são: {DadosDoJogo.heroisdisponiveis.Count}");  
            Console.WriteLine($"O numero de Inimigos disponiveis são: {DadosDoJogo.inimigosdisponiveis.Count}");
        }

    }
    
}