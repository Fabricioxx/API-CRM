# API-CRM ( ASP.NET Core e RESTful design)


* Criação de uma aplicação Web API

````
dotnet new webapi --name API-CRM -f net6.0
````

* Rodar uma aplicação
  
````
dotnet run
````

* Rodar uma aplicação com o watch ( abre o swagger )

````
dotnet watch run
````

* Restaura as dependências e as ferramentas de um projeto.

````
 dotnet restore
````

* Adiciona uma referência de pacote a um projeto.

 ````
 dotnet add package NomeDoPacote
````

* Instalar a ferramenta de gerenciamento do Entity Framework

````
dotnet tool install --global dotnet-ef --version x
````

* Adicionar uma nova migração

````
 dotnet ef migrations add NomeMigracao
 ````

* Atualizar o banco de dados conforme a última migração

````
dotnet ef database update
````
  
  
-----------------------------------------------------------


 * Estrutura base de um Controller api asp.net


 ````csharp

   using Microsoft.AspNetCore.Mvc;

    namespace API_CRM.Controllers
    {

    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
       
      


    }
}
 
 ````


* Entity Framework Core: ( bibliotecas banco de dados)

```````
dotnet add package Microsoft.EntityFrameworkCore <- biblioteca principal

dotnet add package Microsoft.EntityFrameworkCore.SQLite <- provedor de banco de dados específico (por exemplo, SQL Server, SQLite, PostgreSQL, etc.)

dotnet add package Microsoft.EntityFrameworkCore.Design <- executar migrações e criar o contexto de banco de dados

dotnet add package Microsoft.EntityFrameworkCore.Tools <- permitem executar migrações e outras operações no projeto


```````

* Pacote do banco de dados (opcional): Se você estiver usando um banco de dados específico, pode ser necessário adicionar o pacote do banco de dados. Por exemplo, para o SQL Server:

```````
dotnet add package Microsoft.Data.SqlClient

```````


* JWT

``````
dotnet add package System.IdentityModel.Tokens.Jwt

dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

``````










  
