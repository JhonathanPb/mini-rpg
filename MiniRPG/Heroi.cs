namespace MiniRPG
{
    public class Heroi
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public double Defesa { get; set; }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
        }

        public int Atacar()
        {
            return Ataque;
        }    
    }
}