using RakingDeJogos.ranking.Conta;
using RakingDeJogos.ranking.Exceptions;

namespace SistemaRakingDeJogos.ranking
{
    internal class RankingJogos
    {
        private List<Jogador> _listaDeContas = new List<Jogador>();

        public void Menu()
        {
            try
            {
                char opcao = '0';
                while (opcao != '7')
                {
                    Console.Clear();
                    Console.WriteLine("---       Bem vindo ao Ranking de Jogos e Jogares       ---");
                    Console.WriteLine("--- 1 - Cadastrar Jogador   ---");
                    Console.WriteLine("--- 2 - Listar ranking      ---");
                    Console.WriteLine("--- 3 - Atualizar pontuação ---");
                    Console.WriteLine("--- 4 - Pesquisar Jogador   ---");
                    Console.WriteLine("--- 5 - Remover Jogador     ---");
                    Console.WriteLine("--- 6 - Mostrar Top 3       ---");
                    Console.WriteLine("--- 7 - Sair do Sistema     ---");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");
                    string entrada = Console.ReadLine();
                    try
                    {
                        if (string.IsNullOrEmpty(entrada))
                            throw new RankingJogosException("Entrada inválida: não digitou nenhuma opção.");

                        opcao = entrada[0];
                    }
                    catch (RankingJogosException excecao)
                    {
                        Console.WriteLine(excecao.Message);
                        opcao = '0'; 
                    }
                    switch (opcao)
                        {
                            case '1':
                                CadastrarConta();
                                break;
                            case '2':
                                ListarRanking();
                                break;
                            case '3':
                                AtualizarPontuacao();
                                break;
                            case '4':
                                PesquisarJogadorPorNome();
                                break;
                            case '5':
                                RemoverJogador();
                                break;
                            case '6':
                                MostrarTop3Jogares();
                                break;
                            case '7':
                                SairDoSistema();
                                break;
                            default:
                                Console.WriteLine("Opcao não implementada.");
                                break;
                        }
                    }
                }
            catch (RankingJogosException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
        }
        public void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("---   CADASTRO DE JOGARES    ---");
            Console.WriteLine("\n");
            Console.Write("Nome do Jogador ");
            string nome = (Console.ReadLine());

            Console.WriteLine("Qual sua pontuação: ");
            int pontuacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu email para cadastro? ");
            string email = (Console.ReadLine());

            Console.WriteLine("Digite sua senha (podendo conter apenas números e letras)");
            string senha = (Console.ReadLine());

            Console.WriteLine("... Conta Cadastrada! ...");
            Console.ReadKey();

            _listaDeContas.Add(new Jogador(nome, pontuacao, 0, email, senha));

        }

        public void ListarRanking()
        {
            Console.Clear();
            Console.WriteLine("---   RANKING DOS JOGARES    ---");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há jogadores neste ranking.");
                Console.ReadKey();
                return;
            }
            foreach (var jogador in _listaDeContas.OrderByDescending(j => j.Pontuacao))
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Nome: {jogador.Nome} - Pontuação: {jogador.Pontuacao}" );
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        public void AtualizarPontuacao()
        {
            Console.Clear();
            Console.WriteLine("---   ATUALIZAR PONTUAÇÃO    ---");
            Console.WriteLine("\n");
            Console.Write("Digite o nome do jogador que deseja atualizar a pontuação: ");
            string nome = Console.ReadLine();
            var jogador = _listaDeContas.FirstOrDefault(j => j.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (jogador == null)
            {
                Console.WriteLine("Jogador não encontrado.");
                Console.ReadKey();
                return;
            }
            Console.Write("Digite a nova pontuação: ");
            if (int.TryParse(Console.ReadLine(), out int novaPontuacao))
            {
                jogador.Pontuacao = novaPontuacao;
                Console.WriteLine("Pontuação atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Pontuação inválida.");
            }
            Console.ReadKey();
        }

        public void PesquisarJogadorPorNome()
        {
            Console.Clear();
            Console.WriteLine("---   PESQUISAR JOGADOR    ---");
            Console.WriteLine("\n");
            Console.Write("Digite o nome do jogador que deseja encontrar: ");
            string nome = Console.ReadLine();
            var jogador = _listaDeContas.FirstOrDefault(j => j.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (jogador == null)
            {
                Console.WriteLine("Jogador não encontrado.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Informações do jogador: ");
                Console.WriteLine($"Nome: {jogador.Nome} - Pontuação: {jogador.Pontuacao}");
            }
        }

        public void RemoverJogador()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("---     REMOVER CONTA      ---");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\n");
            Console.Write("Informe o nome do jogador: ");
            string nome = Console.ReadLine();

            var jogador = _listaDeContas.FirstOrDefault(j => j.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (jogador != null)
            {
                _listaDeContas.Remove(jogador);
                Console.WriteLine("... Conta removida com sucesso! ...");
            }
            else
            {
                Console.WriteLine("... Jogador não encontrado! ...");
            }
            Console.ReadKey();
        }
        public void MostrarTop3Jogares()
        {
            Console.Clear();
            Console.WriteLine("---   TOP 3 JOGARES    ---");
            Console.WriteLine("\n");
            var top3 = _listaDeContas.OrderByDescending(j => j.Pontuacao).Take(3).ToList();
            if (top3.Count == 0)
            {
                Console.WriteLine("Não há jogadores cadastrados.");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < top3.Count; i++)
            {
                var jogador = top3[i];
                Console.WriteLine($"Posição {i + 1}: {jogador.Nome} - Pontuação: {jogador.Pontuacao}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        public void SairDoSistema()
        {
            Console.Clear();
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
        }
    }
}
