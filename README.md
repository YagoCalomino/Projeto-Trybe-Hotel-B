# Trybe Hotel - Fase B

Boas-vindas ao repositório do projeto Trybe Hotel - Fase B

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis
---

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu projeto você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Sua empresa do coração começou a desenvolver um software de booking de várias redes de hotéis.
Sua missão é continuar o desenvolvimento dessa API criando rotas de autenticação, adicionando segurança a rotas previamente criadas e criando rotas seguras.

</details>
  
<details>
  <summary><strong>📝 Habilidades a serem trabalhadas </strong></summary>

Neste projeto, verificamos se você é capaz de:

- Entender do funcionamento do ASP.NET e como ele se integra ao C#.
- Criar rotas de autenticação usando tokens JWT.
- Criar políticas de autorização.
- Utilizar políticas de autorização em rotas seguras.


</details>


## Orientações
---

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/csharp-034-csharp-projeto-trybe-hotel-fase-b.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-034-csharp-projeto-trybe-hotel-fase-b`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-csharp-034-csharp-projeto-trybe-hotel-fase-b`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-csharp-034-csharp-projeto-trybe-hotel-fase-b`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-034-csharp-projeto-trybe-hotel-fase-b/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-0x-projeto-trybe-hotel/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-034-csharp`.

  Caso tenha alguma dúvida, [aqui tem um vídeo explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

## Requisitos do projeto

Você está desenvolvendo uma API que será utilizada em uma aplicação de booking de várias redes de hotéis.

Na primeira fase deste projeto, você desenvolveu algumas rotas de entidades acerca de cidades, hotéis e quartos. Chegou a hora de construir rotas para o cadastro e login de pessoas clientes e o cadastro de reservas.

No intuito de auxiliar o desenvolvimento, o time de produto já disponibilizou o diagrama de entidade-relacionamento atualizado e o time de DevOps disponibilizou um container na qual você poderá utilizar um banco de dados.

O sistema está dividido em diretórios específicos para auxiliar na organização e desenvolvimento do projeto.

- `Controllers/`: Este diretório armazena os arquivos com as lógicas dos controllers da aplicação. Os métodos a serem desenvolvidos estão prontos mas sem implementação alguma, o que você desenvolverá ao longo do projeto.
<br />

- `Models/`: Este diretório armazena os arquivos com as models do banco de dados. Você já desenvolveu as models `City`, `Hotel` e `Room` que serão as instruções para as tabelas `Cities`, `Hotels` e `Rooms`. Agora você irá desenvolver as models `User` e `Booking` que serão as instruções para as tabelas `Users` e `Bookings`. Lembre-se, o nome da tabela não é dado pelo nome da model mas sim pelo nome do `DBSet<model>` presente no contexto.
<br />

- `DTO/`: Este diretório armazena as classes de DTO. Algumas rotas esperam as `responses` baseadas nestes DTOs. Você pode conferir isso pelo requisito do projeto e pelo retorno dos métodos dos `repositories`.
<br />

- `Repository/`: Este diretório armazena as lógicas que farão a interação com o banco de dados. Os métodos de cada requisito já estão criados e você deverá incluir a implementação de cada um desses métodos respeitando o retorno do DTO. Além disso, você terá o arquivo `TrybeHotelContext` com o contexto para a conexão com o banco de dados. Todos os `repository` e o `context` possuem interfaces que estão nesse diretório e fornecem o contrato para essas classes. Caso você precise criar um novo método para interação com o banco de dados que não esteja mapeado, você pode livremente criar esse novo método na `repository` mas sem se esquecer de escrever o contrato deste método na interface referente.
<br />

<details id='der'>
  <summary><strong>🎲 Banco de Dados</strong></summary>
  <br/>

  Para o desenvolvimento, o time de produto disponibilizou um *Diagrama de Entidade-Relacionamento (DER)* para construir a modelagem do banco de dados. Com essa imagem você já consegue saber:
  - Como nomear suas tabelas e colunas;
  - Quais são os tipos de suas colunas;
  - Relações entre tabelas.

    ![banco de dados](img/der.png)

  O diagrama infere 05 tabelas:
  - ***Cities***: tabela que armazenará um conjunto de cidades nas quais os hotéis estão localizados (já desenvolvida).
  - ***Hotels***: tabela que armazenará os hotéis da nossa aplicação. Note que informamos o `CityId`, atributo que armazenará o id da cidade (já desenvolvida).
  - ***Rooms***: tabela que armazenará os quartos de cada hotel da nossa aplicação. Note que informamos o `HotelId`, atributo que armazenará o id do hotel (já desenvolvida).
  - ***Users***: tabela que armazenará as pessoas usuárias do sistema.
  - ***Bookings***: tabela que armazenará as reservas de quartos de hotéis. Note que informamos os atributos `UserId`, que armazenará o id da pessoa usuária e `RoomId`, que armazenará o id do quarto reservado.

  Acerca dos relacionamentos, pelo diagrama de entidade-relacionamento temos:
  - Uma cidade pode ter vários hotéis.
  - Um hotel pode ter vários quartos.
  - Uma pessoa usuária pode ter várias reservas.
  - Um quarto pode ter várias reservas.

  ⚠️ **Você poderá criar migrations para visualizar o banco de dados**

</details>

<details>
<summary><strong>🐳 Docker</strong></summary><br />

Para auxiliar no desenvolvimento, este projeto possui um arquivo do docker compose para subir um serviço do banco de dados `Azure Data Studio`. Este banco de dados possui a mesma arquitetura do `SQL Server`.

Para subir o serviço, utilize o comando:

```shell
docker-compose up -d --build
```

Para conectar ao seu sistema de gerenciamento de banco de dados, utilize as seguintes credenciais:

- `Server`: localhost
- `User`: sa
- `Password`: TrybeHotel12!
- `Database`: TrybeHotel
- `Trust server certificate`: true

Para criar o contexto do banco de dados na sua aplicação, utilize como connection string:

```csharp
var connectionString = "Server=localhost;Database=TrybeHotel;User=SA;Password=TrybeHotel12!;TrustServerCertificate=True";
```

⚠️ ** Essa connection string poderá ser utilizada no requisito 1 **

</details>

<details id='refatorando'>
  <summary>Continuando o projeto Trybe Hotel</summary>

Você já iniciou o projeto da nossa aplicação e portanto, todas as funcionalidades podem ser trazidas para não duplicar o funcionamento. Isso será muito importante, especialmente no que diz respeito ao banco de dados. Algumas models do seu banco de dados anterior serão referenciadas nas models agora, portanto, vamos trazer as funcionalidades anteriores.

Mas como fazemos isso:

Após clonar o repositório deste projeto, apenas copie e cole as funcionalidades que você construiu anteriormente:

- `Controllers`: copie todos os arquivos do diretório `Controllers` do projeto anterior e cole no diretório `Controllers` deste projeto.
- `Dto`: copie todos os arquivos do diretório `Dto` do projeto anterior e cole no diretório `Dto` deste projeto.
- `Models`: copie os arquivos referentes às models `City`, `Hotel` e `Room` do projeto anterior e cole no diretório `Models` deste projeto.
- `Repository`: copie os arquivos `CityRepository`, `RoomRepository` e `HotelRepository` do projeto anterior e cole no diretório `Repository` deste projeto. Não copie as interfaces. Para o arquivo `TrybeHotelContext`, não o substitua. Apenas adicione os `DBSets` e implemente os métodos `OnConfiguring()` e `OnModelCreating()`.
- `Migrations`: Se você possui um diretório de migrations, significa que você criou migrations no projeto anterior. Não copie este diretório e crie migrations novas porque a instância do banco de dados no container não será o mesmo.
- `Testes`: No projeto de testes, você pode copiar a funcionalidade do arquivo `src/TrybeHotel.Test/IntegrationTest.cs`.

</details>


### 1. Implemente as models da aplicação

<details>
  <summary><strong>Mais informações:</strong></summary>

  Implemente os arquivos do diretório `/src/TrybeHotel/Models/`

  <details>
    <summary>Implemente as models do projeto anterior</summary>

  Você pode copiar todas as models do projeto anterior.

  Siga as instruções da seção [Continuando o projeto Trybe hotel](#refatorando)

  </details>

  <details>
    <summary>Implemente a model <code>User</code></summary>
    <br />
User representará as pessoas usuárias da aplicação e deverá conter os seguintes campos:

- `UserId`: Chave primária (int)
- `Name`: string
- `Email`: string
- `Password`: string
- `UserType`: string 

Cada pessoa usuária tem várias reservas. A propriedade de navegação para `Booking` deve se chamar `Bookings` (anulável).

O atributo `UserType`, no futuro, receberá os valores `admin` ou `client` e representará a nossa autorização.

Em caso de dúvidas, consulte o [diagrama de entidade-relacionamento](#der)
  </details>

  <details>
    <summary>Implemente a model <code>Booking</code></summary>
    <br />
Booking representará as reservas da aplicação e deverá conter os seguintes campos:

- `BookingId`: Chave primária (int)
- `CheckIn`: Datetime (data da entrada)
- `CheckOut`: Datetime (data de saída)
- `GuestQuant`: int (número de hóspedes no quarto)
- `UserId`: int (chave estrangeira que representa a pessoa usuária que está reservando o quarto) 
- `RoomId`: int (chave estrangeira que representa o quarto que está sendo reservado) 

Cada reserva tem uma pessoa usuária. A propriedade de navegação para `User` deve se chamar `User` (anulável).
Cada reserva tem um quarto. A propriedade de navegação para `Room` deve se chamar `Room` (anulável).

Em caso de dúvidas, consulte o [diagrama de entidade-relacionamento](#der)
  </details>
  
  <details>
    <summary>Implemente o contexto do banco de dados</summary>
    <br />

Finalize a implementação do contexto da aplicação no arquivo `src/TrybeHotel/Repository/TrybeHotelContext.cs`.

O contexto deverá ter todas as models da aplicação com os nomes `Cities`, `Hotels`, `Rooms`, `Users` e `Bookings`.

Faça um `override` do método `OnConfiguring` para o contexto se conectar ao seu banco de dados local.

Caso você queira executar o seu projeto para testar localmente, utilize o arquivo docker-compose.yml com um banco SqlServer. Caso você queira usar essa base, tenha o Docker e o docker-compose instalado na sua máquina!

Caso utilize este banco, configure a sua connectionString como:

```csharp
var connectionString = "Server=localhost;Database=TrybeHotel;User=SA;Password=TrybeHotel12!;TrustServerCertificate=True";
```

Você pode criar as tabelas do banco de dados atráves dos comandos `dotnet ef migrations add InitialCreate` e `dotnet ef database update`. Caso você execute esse comando, certifique-se de que o CLI do Entity Framework esteja instalado na sua máquina!
  </details>


<br />

**O que será testado:**

- Será testado que todas as models foram implementadas corretamente.
- Será testado que as models possuem as chaves primárias e estrangeiras necessárias.

</details>


### 2. Desenvolva o endpoint POST /user

<details>
  <summary><strong>Mais informações:</strong></summary>


- Este endpoint será responsável por inserir uma nova pessoa usuária.
- Implemente a lógica da sua controller no método `Add()` do arquivo `src/TrybeHotel/Controllers/UserController.cs`.
- Implemente a lógica de interação ao banco de dados no método `Add()` do arquivo `src/TrybeHotel/Repository/UserRepository.cs`.
- A sua repository retorna um tipo `UserDto` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/UserDto.cs`. A sua classe de DTO deve seguir o formato da response da requisição. 
- O corpo da sua requisição deve seguir o tipo `UserDtoInsert` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/UserDto.cs`. A sua classe de DTO deve seguir o formato da request da requisição. 

<br />

👀 **De olho na dica:** Monte o retorno do seu repository com os conhecimentos de `LINQ` e `DTO` já obtidos.
<br />

👀 **De olho na dica 2:** Para obter um único elemento de uma coleção, você pode obter o primeiro com o método `First()`. Exemplo: `coleção.First()`.

<br />

- O endpoint deve ser acessível através da URL `/user` e deve ser do tipo `POST`;
- O atributo `userType` deve ser salvo com o valor `client`.
- O corpo da requisição deve seguir o padrão abaixo

```json
{
	"Name":"Rebeca",
	"Email": "rebeca.santos@trybehotel.com",
	"Password": "123456"
}
```
  <details>
    <summary>Será testado que não é possível inserir uma pessoa usuária com e-mail repetido</summary>

- Caso o e-mail seja repetido, a pessoa usuária não deve ser cadastrada.
- A resposta deve ser o status `409`.
- O corpo da resposta deve seguir o formato abaixo:


```json
{
  "message": "User email already exists"
}
```

**O que será testado:**

- Será testado que o status de retorno será `409`.
- Será testado que o corpo da resposta segue o padrão esperado.

</details>

  <details>
    <summary>Será testado que é possível inserir uma pessoa usuária com sucesso</summary>

- Caso o e-mail não seja repetido, a pessoa usuária deve ser cadastrada com sucesso.
- A resposta deve ser o status `201`.
- O corpo da resposta deve seguir o formato abaixo:

```json

{
  "userId": 1,
	"Name":"Rebeca",
	"Email": "rebeca.santos@trybehotel.com",
	"userType": "client"
}
```

**O que será testado:**

- Será testado que, quando solicitada a requisição, a mesma insira no banco de dados e retorne de acordo com o modelo
- Será testado que o status de retorno será `201`.
- Será testado que o corpo da resposta segue o padrão esperado.
  </details>


 ⚠️ A partir da criação deste endpoint, você poderá utilizar o cadastro de pessoas usuárias. O sistema automaticamente cadastrará uma pessoa usuária `admin` com o e-mail `admin@admin.com` e senha `admin`. Você também pode alterar qualquer pessoa usuária para `admin` realizando um update no banco de dados com o comando `SQL`:

```sql
UPDATE Users SET UserType = 'admin' where UserId = 1
```

Substitua o número `1` pelo id da pessoa usuária que você deseja adicionar permissão de `admin`.


</details>

### 3. Desenvolva o endpoint POST /login

<details>
  <summary><strong>Mais informações:</strong></summary>


- Este endpoint será responsável por fazer um login.
- Implemente a lógica da sua controller no método `Login()` do arquivo `src/TrybeHotel/Controllers/LoginController.cs`.
- Implemente a lógica de interação ao banco de dados no método `lOGIN()` do arquivo `src/TrybeHotel/Repository/UserRepository.cs`.
- A sua repository retorna um tipo `UserDto` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/UserDto.cs`. A sua classe de DTO deve seguir o formato da response da requisição. 
- O corpo da sua requisição deve seguir o tipo `LoginDto` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/UserDto.cs`. A sua classe de DTO deve seguir o formato da request da requisição. 
- A lógica para criar o token pode ser implementada nos métodos `Generate` e `AddClaims` no arquivo `src/TrybeHotel/Services/TokenGenerator.cs`.
- Adicione em suas claims, uma claim com o tipo `ClaimType.Email` e o valor do e-mail da pessoa usuária.
- Caso a pessoa usuária seja do tipo `admin`, adicione em suas claims, uma claim com o tipo `ClaimType.Role` e o valor `admin`.

<br />

👀 **De olho na dica:** Monte o retorno do seu repository com os conhecimentos de `LINQ` e `DTO` já obtidos.
<br />

👀 **De olho na dica 2:** Para obter um único elemento de uma coleção, você pode obter o primeiro com o método `First()`. Exemplo: `coleção.First()`.


<br />

- O endpoint deve ser acessível através da URL `/login` e deve ser do tipo `POST`;
- O corpo da requisição deve seguir o padrão abaixo

```json
{
	"Email": "rebeca.santos@trybehotel.com",
	"Password": "123456"
}
```
  <details>
    <summary>Será testado que não é possível fazer login com credenciais erradas</summary>

Caso a combinação e-mail e senha não existam:
- A resposta deve ser o status `401`.
- O corpo da resposta deve seguir o formato abaixo:


```json
{
  "message": "Incorrect e-mail or password"
}
```

**O que será testado:**

- Será testado que o status de retorno será `401`.
- Será testado que o corpo da resposta segue o padrão esperado.

</details>

  <details>
    <summary>Será testado que é possível fazer login com sucesso</summary>

- Caso as credenciais estejam corretas:
- A resposta deve ser o status `200`.
- O corpo da resposta deve seguir o formato abaixo:

```json

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyb2xlIjoiYWRtaW4iLCJlbWFpbCI6ImRhbmlsby5zaWx2YUBiZXRyeWJlLmNvbSIsIm5iZiI6MTY4ODQxMTIxMiwiZXhwIjoxNjg4NDk3NjEyLCJpYXQiOjE2ODg0MTEyMTJ9.q1cNj2_xspeQC6Uz1maV79P95hVtWH4Z7auZgOen-Qo",
}
```

**O que será testado:**

- Será testado que o status de retorno será `200`.
- Será testado que o corpo da resposta segue o padrão esperado.
  </details>

</details>


### 4. Adicione a autorização de admin no endpoint /POST hotel


<details>
  <summary><strong>Mais informações:</strong></summary>

  - Este endpoint já foi desenvolvido na fase anterior. Agora iremos apenas adicionar uma permissão de admin.

  Você pode copiar todas as controllers do projeto anterior.

  Siga as instruções da seção [Continuando o projeto Trybe hotel](#refatorando)

  - Crie uma política chamada `Admin` que requira a claim `ClaimType.Email` e a claim `ClaimType.Role` como `admin`.
  - Crie uma política chamada `Client` que requira a claim `ClaimType.Email`.
  - As políticas devem ser criadas no arquivo `src/TrybeHotel/Program.cs`.
  - A adição da autorização da política no controller deve ser feita no arquivo `src/TrybeHotel/Controllers/HotelController.cs`.

**O que será testado:**

- Será validado que é possível realizar as operações do endpoint com a autorização de admin.
- Será validado que o status será proibido caso o acesso não seja admin.
- Será validado que o status será não autorizado caso o acesso não exista.

</details>


### 5. Adicione a autorização de admin no endpoint /POST room

<details>
  <summary><strong>Mais informações:</strong></summary>

  - Este endpoint já foi desenvolvido na fase anterior. Agora iremos apenas adicionar uma permissão de admin.

  Você pode copiar todas as controllers do projeto anterior.

  Siga as instruções da seção [Continuando o projeto Trybe hotel](#refatorando)

  - Crie uma política chamada `Admin` que requira a claim `ClaimType.Email` e a claim `ClaimType.Role` como `admin`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - Crie uma política chamada `Client` que requira a claim `ClaimType.Email`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - As políticas devem ser criadas no arquivo `src/TrybeHotel/Program.cs`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - A adição da autorização da política no controller deve ser feita no arquivo `src/TrybeHotel/Controllers/RoomController.cs`.

**O que será testado:**

- Será validado que é possível realizar as operações do endpoint com a autorização de admin.
- Será validado que o status será proibido caso o acesso não seja admin.
- Será validado que o status será não autorizado caso o acesso não exista.

</details>


### 6. Adicione a autorização de admin no endpoint /DELETE room

<details>
  <summary><strong>Mais informações:</strong></summary>

  - Este endpoint já foi desenvolvido na fase anterior. Agora iremos apenas adicionar uma permissão de admin.

  Você pode copiar todas as controllers do projeto anterior.

  Siga as instruções da seção [Continuando o projeto Trybe hotel](#refatorando)

  - Crie uma política chamada `Admin` que requira a claim `ClaimType.Email` e a claim `ClaimType.Role` como `admin`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - Crie uma política chamada `Client` que requira a claim `ClaimType.Email`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - As políticas devem ser criadas no arquivo `src/TrybeHotel/Program.cs`. Este é o mesmo desenvolvimento do requisito anterior. Caso já tenha feito, pule esta parte.
  - A adição da autorização da política no controller deve ser feita no arquivo `src/TrybeHotel/Controllers/RoomController.cs`.

**O que será testado:**

- Será validado que é possível realizar as operações do endpoint com a autorização de admin.
- Será validado que o status será proibido caso o acesso não seja admin.
- Será validado que o status será não autorizado caso o acesso não exista.

</details>



### 7. Desenvolva o endpoint POST /booking

<details>
  <summary><strong>Mais informações:</strong></summary>


- Este endpoint será responsável por inserir uma nova reserva.
- Implemente a lógica da sua controller no método `Add()` do arquivo `src/TrybeHotel/Controllers/BookingController.cs`.
- Implemente a lógica de interação ao banco de dados no método `Add()` do arquivo `src/TrybeHotel/Repository/BookingRepository.cs`.
- A sua repository retorna um tipo `BookingResponse` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/BookingDto.cs`. A sua classe de DTO deve seguir o formato da response da requisição. 
- O corpo da sua requisição deve seguir o tipo `BookingDtoInsert` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/BookingDto.cs`. A sua classe de DTO deve seguir o formato da request da requisição. 
<br />

👀 **De olho na dica:** Monte o retorno do seu repository com os conhecimentos de `LINQ` e `DTO` já obtidos.
<br />

👀 **De olho na dica 2:** Para obter um único elemento de uma coleção, você pode obter o primeiro com o método `First()`. Exemplo: `coleção.First()`.

<br />

- O endpoint deve ser acessível através da URL `/booking` e deve ser do tipo `POST`;
- O endpoint deve ter autorização para a Política `Client` (desenvolvida nos requisitos 4, 5 ou 6).
- O endpoint deve obter a pessoa usuária pelo token.
- O corpo da requisição deve seguir o padrão abaixo

```json
{
	"CheckIn":"2030-08-27",
	"CheckOut":"2030-08-28",
	"GuestQuant":"1",
	"RoomId":1
}
```
  <details>
    <summary>Será testado que não é possível inserir uma reserva se a quantidade de hóspedes for maior do que a capacidade do quarto</summary>

- Caso o valor `GuestQuant` seja maior do que o valor de `Capacity` do quarto escolhido, a reserva não deve ser realizada.
- A resposta deve ser o status `400`.
- O corpo da resposta deve seguir o formato abaixo:


```json
{
  "message": "Guest quantity over room capacity"
}
```

**O que será testado:**

- Será testado que o status de retorno será `400`.
- Será testado que o corpo da resposta segue o padrão esperado.

</details>

  <details>
    <summary>Será testado que é possível inserir uma nova reserva com sucesso</summary>

- A resposta deve ser o status `201`.
- O corpo da resposta deve seguir o formato abaixo:

```json

{
	"bookingId": 1,
	"checkIn": "2030-08-27T00:00:00",
	"checkOut": "2030-08-28T00:00:00",
	"guestQuant": 1,
	"room": {
		"roomId": 1,
		"name": "Suite básica",
		"capacity": 2,
		"image": "image suite",
		"hotel": {
			"hotelId": 1,
			"name": "Trybe Hotel RJ",
			"address": "Avenida Atlântica, 1400",
			"cityId": 1,
			"cityName": "Rio de Janeiro"
		}
	}
}
```

**O que será testado:**

- Será testado que, quando solicitada a requisição, a mesma insira no banco de dados e retorne de acordo com o modelo
- Será testado que o status de retorno será `201`.
- Será testado que o corpo da resposta segue o padrão esperado.
  </details>

</details>



### 8. Desenvolva o endpoint GET /booking

<details>
  <summary><strong>Mais informações:</strong></summary>


- Este endpoint será responsável por listar uma única reserva.
- Implemente a lógica da sua controller no método `GetBooking()` do arquivo `src/TrybeHotel/Controllers/BookingController.cs`.
- Implemente a lógica de interação ao banco de dados no método `GetBooking()` do arquivo `src/TrybeHotel/Repository/BookingRepository.cs`.
- A sua repository retorna um tipo `BookingResponse` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/BookingDto.cs`. A sua classe de DTO deve seguir o formato da response da requisição. 
<br />

- O endpoint deve ser acessível através da URL `/booking/:id` e deve ser do tipo `GET`;
- O corpo da requisição é vazio.
- O id da reserva deve estar na URL.
- O endpoint deve conter autorização da política `Client` e deve responder apenas a consultas da pessoa usuária que realizou a reserva.
<br />


👀 **De olho na dica:** Monte o retorno do seu repository com os conhecimentos de `LINQ` e `DTO` já obtidos.
<br />

👀 **De olho na dica 2:** Para converter qualquer tipo de coleção no tipo de coleção `List`, utilize o método `ToList()`.
<br />

👀 **De olho na dica 3:** Para obter um único elemento de uma coleção, você pode obter o primeiro com o método `First()`. Exemplo: `coleção.First()`.
<br />


  <details>
    <summary>Será testado que não é possível consultar uma reserva com credencial inválida</summary>

  Caso a credencial não exista ou esteja errada:
  - A resposta deve ser o status `401`.

  </details>

  <details>
    <summary>Será testado que é possível consultar uma reserva com sucesso</summary>

  - A resposta deve ser o status `200`.
  - O corpo da resposta deve seguir o formato abaixo:

  ```json
  {
  	"bookingId": 1002,
  	"checkIn": "2023-08-27T00:00:00",
  	"checkOut": "2023-08-28T00:00:00",
  	"guestQuant": 1,
  	"room": {
		  "roomId": 1,
		  "name": "Suite básica",
		  "capacity": 2,
		  "image": "image suite",
		  "hotel": {
  			"hotelId": 1,
			  "name": "Trybe Hotel RJ",
			  "address": "Avenida Atlântica, 1400",
			  "cityId": 1,
			"c  ityName": "Rio de Janeiro"
		  }
	  }
  }
  ```

  </details>

</details>


### 9. Desenvolva o endpoint GET /user


<details>
  <summary><strong>Mais informações:</strong></summary>


- Este endpoint será responsável por listar todas as pessoas usuárias.
- Implemente a lógica da sua controller no método `GetUsers()` do arquivo `src/TrybeHotel/Controllers/UserController.cs`.
- Implemente a lógica de interação ao banco de dados no método `GetUsers()` do arquivo `src/TrybeHotel/Repository/UserRepository.cs`.
- A sua repository retorna um tipo `UserDto` que deverá ser implementado no arquivo `src/TrybeHotel/Dto/UserDto.cs`. A sua classe de DTO deve seguir o formato da response da requisição. 
<br />

- O endpoint deve ser acessível através da URL `/user` e deve ser do tipo `GET`;
- O corpo da requisição é vazio.
- O endpoint deve conter autorização da política `Admin` e deve responder apenas a consultas da pessoa usuária com essa permissão.

<br />

👀 **De olho na dica:** Monte o retorno do seu repository com os conhecimentos de `LINQ` e `DTO` já obtidos.
<br />

👀 **De olho na dica 2:** Para converter qualquer tipo de coleção no tipo de coleção `List`, utilize o método `ToList()`.
<br />


  <details>
    <summary>Será testado que não é possível consultar uma reserva com credencial inválida</summary>

  Caso a credencial não exista ou esteja errada:
  - A resposta deve ser o status `401`.

  </details>

  <details>
    <summary>Será testado que é possível consultar uma reserva com sucesso</summary>

  - A resposta deve ser o status `200`.
  - O corpo da resposta deve seguir o formato abaixo:

  ```json
  [
	  {
  	  "userId": 1,
		  "name": "Rebeca",
		  "email": "rebeca.santos@trybehotel.com",
		  "userType": "client"
	  }, 
    /*...*/
  ]
  ```

  </details>
</details>


### 10. Desenvolva testes que cubram no mínimo 40% de linhas

<details>
  <summary><strong>Mais informações:</strong></summary>

- Desenvolva testes de integração que cubram 40% das linhas de código.
- Os testes devem ser implementados no arquivo `src/TrybeHotel.Test/IntegrationTest.cs`
- Este arquivo possui uma classe chamada `IntegrationTest`. Cada método dessa classe é um teste diferente.
- O construtor da classe `IntegrationTest` cria um `context` em memória de um banco de dados que será utilizado nos testes. Verifique neste construtor quais são as cidades, hotéis e quartos disponíveis no banco de dados que será utilizado no teste 👀.
- Este arquivo de testes já possui um método `TestGet` que testa a rota GET `/room`. Utilize o mesmo como exemplo para criar novos métodos e testar outras rotas.

**O que será testado:**

- Será avaliado que os testes cubram 40% das linhas de código.

</details>


<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH34-CSHARP&template=betrybe/csharp-0x-projeto-trybe-hotel-fase-b)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>
