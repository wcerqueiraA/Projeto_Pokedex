# PokedexApp

Este é um projeto simples de uma Pokedex desenvolvido em ASP.NET Core utilizando C#. 
O objetivo é permitir que os usuários pesquisem por pokémons e vejam detalhes como tipo, altura e peso.

## Dependências

    - Linguagem: C#
    - .NET Core 7
    - HTML5
    - CSS3
    - Bootstrap
    - Javascript
    - Visual Studio 2022 para desenvolvimento

## Instalação
1. Clone o repositório:

bash
git clone https://github.com/seu-usuario/PokedexApp.git

2. Abra o arquivo de solução PokedexApp.sln no Visual Studio.
  
## Estrutura do Projeto

### O projeto está estruturado da seguinte forma:

    - Program.cs: Configuração inicial da aplicação ASP.NET Core.
    - appsettings.json: Arquivo de configuração para logging e permissões de host.
    - PokeApiService.cs: Serviço para comunicação com a PokeApi.
    - Pages/Index.cshtml: Página inicial da aplicação, contendo o formulário de pesquisa e a exibição dos detalhes do pokémon.
    - Pages/Index.cshtml.cs: Classe de modelo para a página inicial, que interage com o serviço PokeApiService para buscar e exibir os dados do pokémon.
    - Models/:
        - Pokemon.cs: Define a estrutura de dados do pokémon.
        - Sprite.cs: Define a estrutura dos sprites do pokémon.
        - Tipo.cs e Tipo2.cs: Representam as estruturas dos tipos de pokémon.
    - wwwroot/css/site.css: Folha de estilo para personalização da interface.
    - wwwroot/lib/: Bibliotecas externas utilizadas (Bootstrap e jQuery).

## Funcionalidades

    - Pesquisa de Pokémon: Permite aos usuários buscar por um pokémon específico.
    - Exibição de Detalhes: Após a pesquisa, exibe os detalhes do pokémon encontrado, incluindo nome, tipo(s), altura, peso e imagem.
    - Estilização por Tipo: Cada tipo de pokémon é exibido com uma cor de fundo específica para facilitar a identificação visual.

## Uso

    - Abra a aplicação no navegador.
    - Insira o nome de um pokémon no campo de pesquisa e clique em "Pesquisar".
    - Os detalhes do pokémon serão exibidos, incluindo sua imagem e informações como altura, peso e tipo(s).

## Contribuição

Contribuições são bem-vindas! Para contribuir com melhorias:

    - Fork o repositório.
    - Crie uma branch com sua feature (git checkout -b feature/MinhaFeature).
    - Commit suas mudanças (git commit -am 'Adiciona nova feature').
    - Push para a branch (git push origin feature/MinhaFeature).
    - Crie um novo Pull Request.

## Direitos Autorais e Licença

© 2024 Wellington Cerqueira Araujo

    Este projeto utiliza dados da PokeApi.
    Consulte o arquivo LICENSE para mais detalhes sobre a licença do código-fonte deste projeto.

Este projeto pode ser expandido com mais funcionalidades, como cache de resultados, suporte a múltiplas fontes de dados ou melhorias na interface do usuário.
