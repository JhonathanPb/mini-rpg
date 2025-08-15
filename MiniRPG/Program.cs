namespace MiniRPG
{

    class Program
    {
        public static void Main(string[] args)
        {
            Heroi heroi1 = new Heroi();
            Inimigo inimigo1 = new Inimigo();
            
            heroi1.Nome = "Starlin";
            console.WriteLine($"O nome do Herói escolhido é: {heroi1.Nome}");

        }

    }
    
}