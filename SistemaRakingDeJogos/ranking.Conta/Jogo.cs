namespace RakingDeJogos.ranking.Conta
{
    public class Jogo : IComparable<Jogo>
    {
        public string NomeJogo { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }

        public Jogo(string nomeJogo, string genero, string plataforma)
        {
            NomeJogo = nomeJogo;
            Genero = genero;
            Plataforma = plataforma;
        }
        public int CompareTo(Jogo other)
        {
            return NomeJogo.CompareTo(other.NomeJogo);
        }
    }
}
