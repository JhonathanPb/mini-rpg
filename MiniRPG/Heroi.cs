namespace MiniRPG
{
    class Heroi
    {
        public string nome;
        public string classe;
        public int vida;
        public int ataque;
        public double defesa;

        public void ReceberDano(int dano)
        {
            this.vida -= dano;
        }

        public int atacar()
        {
            return ataque;
        }    
    }
}