using System.Collections.Generic;

namespace MiniRPG
{
    public static class DadosDoJogo
    {
        public static List<Heroi> heroisdisponiveis = new List<Heroi>();
        public static List<Inimigo> inimigosdisponiveis = new List<Inimigo>();

        // Método para carregar os dados dos heróis e inimigos
        public static void CarregadorDados()
        {
            // Heróis
            heroisdisponiveis.Add(new Heroi { Nome = "Starlin", Classe = "Bárbaro", Vida = 100, Ataque = 60, Defesa = 50});
            heroisdisponiveis.Add(new Heroi { Nome = "Logan", Classe = "Guerreiro", Vida = 120, Ataque = 50, Defesa = 70});
            heroisdisponiveis.Add(new Heroi { Nome = "Merlun", Classe = "Mago", Vida = 60, Ataque = 85, Defesa = 10});
            heroisdisponiveis.Add(new Heroi { Nome = "Fin", Classe = "Arqueiro", Vida = 80, Ataque = 45, Defesa = 25});

            // Inimigos
            inimigosdisponiveis.Add(new Inimigo { Nome = "Dragão da Alvorada", Classe = "Draconico", Vida = 120, Ataque = 56, Defesa = 75});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Dragão do Merium", Classe = "Draconico", Vida = 85, Ataque = 65, Defesa = 90});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Troll da Montanha", Classe = "Troll", Vida = 150, Ataque = 40, Defesa = 75});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Troll da Caverna", Classe = "Troll", Vida = 150, Ataque = 55, Defesa = 75});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Cão Maldito", Classe = "Monstro", Vida = 100, Ataque = 25, Defesa = 25});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Largato do Fogo", Classe = "Monstro", Vida = 80, Ataque = 60, Defesa = 35});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Morcego", Classe = "Animal", Vida = 60, Ataque = 25, Defesa = 25});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Aranha", Classe = "Animal", Vida = 60, Ataque = 35, Defesa = 10});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Cobra", Classe = "Animal", Vida = 70, Ataque = 40, Defesa = 15});
            inimigosdisponiveis.Add(new Inimigo { Nome = "Lobo", Classe = "Animal", Vida = 75, Ataque = 45, Defesa = 25});
        }
    }
}