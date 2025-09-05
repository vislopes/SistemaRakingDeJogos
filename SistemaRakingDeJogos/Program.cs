using RakingDeJogos.ranking;
using SistemaRakingDeJogos.ranking;
internal class Program
{
    private static void Main(string[] args) { 
    
        Console.WriteLine("==============================");
        Console.WriteLine("  Bem-vindo ao Ranking de Jogos");
        Console.WriteLine("==============================\n");

        RankingJogos ranking = new RankingJogos();
       
        ranking.Menu();

        Console.WriteLine("\nObrigado por usar o Ranking de Jogos!");
    }
}
