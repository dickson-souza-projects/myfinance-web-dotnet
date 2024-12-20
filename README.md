# Sobre esse repositório

Repositório com o conteúdo do trabalho prático da disciplina **Práticas de Implementação e Evolução de Software** da Pós graduação em Engenharia de Software - Oferta 7 - Turma 1 - do Instituto de Educação Continuada da PUC Minas

# Sobre o projeto

Esse projeto didático teve o intuito de criar uma pequena aplicação financeira para uso pessoal. A aplicação foi criada em ASP.NET MVC (Model-View-Controller) com Razor pages e persistência de dados em Microsoft SQL Server 2022, Developer Edition. O mapeamento dos dados foi feito usando Entity Framework Core 9.

## Como executar a aplicação em ambiente local

### Pré-requisitos
Para executar essa aplicação são necessários os seguintes requisitos:
- Ter o SDK do .NET instalado em versões iguais ou superiores ao **.NET 8**
  - Para essa versão, consulte o link [Download .NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0));
- Um **editor de código** como o `Visual Studio Code` ou uma **IDE** como `Visual Studio Community 2022`
  - Essas são apenas sugestões de uso mas outros editores e IDEs podem ser também usados;
- E uma versão do **Microsoft SQL Server 2022** instalada no seu computador (para criar o banco para o desenvolvimento e execução)
  - Ou ainda acesso a uma instância do **Azure SQL Server** com permissão para criar um novo banco de dados.
- Clonar esse repositório em seu computador usando os comandos abaixo:
```bash
# Escolher um diretório para clonar o repositório
cd {diretório de sua preferência}

# Comando para clonar o repositório
git clone https://github.com/dickson-souza-projects/myfinance-web-dotnet.git

# Acessar o conteúdo do repositório
cd myfinance-web-dotnet
```

