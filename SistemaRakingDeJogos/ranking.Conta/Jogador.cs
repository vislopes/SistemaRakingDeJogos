namespace RakingDeJogos.ranking.Conta
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public static int TotalJogadoresCadastrados { get; private set; }
        public Jogador(string nome,int pontuacao, int v, string email, string senha)
        {
            Nome = nome;
            Pontuacao = pontuacao;
            Email = email;
            Senha = senha;
            TotalJogadoresCadastrados++;
        }
    }
}
