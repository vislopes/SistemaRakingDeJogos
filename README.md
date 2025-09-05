🎮 Sistema de Ranking de Jogos




📖 Descrição

Este projeto é um sistema de console em C# para gerenciar um ranking de jogadores de jogos.
Permite cadastrar jogadores, atualizar pontuações, listar o ranking completo, pesquisar jogadores por nome e exibir os Top 3 jogadores com melhor pontuação.

O sistema utiliza conceitos de:

POO (Programação Orientada a Objetos) com classes e objetos (Jogador, Jogo)

Listas genéricas (List<T>) para armazenar dados dinamicamente

LINQ para buscas e ordenações

Exceções personalizadas (RankingJogosException)

Menu interativo no console

⚙ Funcionalidades

Cadastrar jogador (nome, pontuação, email e senha)

Listar ranking completo

Atualizar pontuação de um jogador

Pesquisar jogador por nome

Mostrar Top 3 jogadores

Sair do sistema

📂 Estrutura do Projeto
RakingDeJogos/
├─ ranking/
│  ├─ Conta/
│  │  ├─ Jogador.cs
│  │  └─ Jogo.cs
│  ├─ Exceptions/
│  │  └─ RankingJogosException.cs
│  └─ RankingJogos.cs
├─ Program.cs
└─ README.md

🛠 Como Executar
Requisitos

Windows / macOS / Linux

Visual Studio Community 2022 ou superior

.NET 6 SDK ou superior

Passos

Abra o projeto no Visual Studio

Compile o projeto (Build Solution)

Execute (Start ou Ctrl + F5)

Interaja com o menu do console digitando o número da opção desejada

🖥 Exemplo de Uso no Console
==============================
  Bem-vindo ao Ranking de Jogos
==============================

1 - Cadastrar Jogador
2 - Listar ranking
3 - Atualizar pontuação
4 - Pesquisar Jogador
5 - Mostrar Top 3
6 - Sair do sistema

Digite a opção desejada: 1
--- CADASTRO DE JOGADORES ---
Nome: Ana
Pontuação: 2500
Email: ana@email.com
Senha: 123abc
... Conta cadastrada com sucesso! ...

Digite a opção desejada: 2
--- RANKING DOS JOGADORES ---
Nome: Ana - Pontuação: 2500
Nome: João - Pontuação: 1900

🚀 Futuras Melhorias

Persistência de dados em arquivo JSON

Sistema de partidas entre jogadores, com atualização automática de pontuação

Validação avançada de email e senha

Adição de filtros por gênero, plataforma ou pontuação mínima

📌 Tecnologias

C# 10 / .NET 6

Console Application

Visual Studio Community
