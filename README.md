# TransacoesService

API RESTful para gerenciamento de transações financeiras, construída com ASP.NET Core seguindo a arquitetura limpa (Clean Architecture) e utilizando MongoDB Atlas como banco de dados.

---

## Estrutura do Projeto

TransacoesService/
│
├── API/ → Camada de apresentação (Controllers)
│ └── Controllers/
│ └── TransacoesController.cs
│
├── Aplicacao/ → Camada de aplicação (DTOs, Serviços)
│ ├── Interfaces/
│ │ └── ITransacaoServico.cs
│ └── Servicos/
│ └── TransacaoServico.cs
│
├── Dominio/ → Camada de domínio (Entidades e Interfaces)
│ ├── Entidades/
│ │ └── Transacao.cs
│ └── Repositorios/
│ └── ITransacaoRepositorio.cs
│
├── Infraestrutura/ → Camada de infraestrutura (MongoDB)
│ ├── Contexto/
│ │ └── MongoDbContexto.cs
│ └── Repositorios/
│ └── TransacaoRepositorio.cs
│
├── wwwroot/swagger-ui/ → Arquivo custom.css para personalizar Swagger UI
│
└── TransacoesService.sln → Solução principal

yaml
Copiar
Editar

---

## Tecnologias Utilizadas

- ASP.NET Core 7+
- MongoDB Atlas
- Swagger UI para documentação da API
- C# 10/11

---

## Configuração do Ambiente

### 1. Configurar MongoDB Atlas

- Crie uma conta em https://www.mongodb.com/cloud/atlas
- Crie um cluster gratuito
- Crie um usuário com senha para conexão
- Obtenha a connection string no formato:

mongodb+srv://<usuario>:<senha>@<cluster>.mongodb.net/

yaml
Copiar
Editar

- Atualize o arquivo `appsettings.json` substituindo `<usuario>`, `<senha>` e `<cluster>` pela sua conexão.

---

### 2. Rodar a aplicação

Na pasta raiz do projeto, execute:

```bash
dotnet run --project API
A aplicação iniciará em:

arduino
Copiar
Editar
https://localhost:5001
3. Testar a API via Swagger
Acesse no navegador:

bash
Copiar
Editar
https://localhost:5001/swagger
Você verá a documentação interativa com visual personalizado.

4. Exemplo de requisição para criar uma transação
Método: POST
URL: https://localhost:5001/api/transacoes

Body JSON:

json
Copiar
Editar
{
  "descricao": "Compra no mercado",
  "valor": 150.00,
  "data": "2025-07-23T00:00:00"
}
Resposta esperada:

json
Copiar
Editar
{
  "mensagem": "Transação criada com sucesso!"
}
Customização do Swagger UI
O arquivo wwwroot/swagger-ui/custom.css personaliza o tema do Swagger:

Barra superior com fundo vermelho escuro

Texto vermelho claro

Botões e elementos estilizados para melhor visualização

Arquitetura Limpa
Dominio: regras de negócio e entidades

Aplicacao: serviços e interfaces que orquestram operações

Infraestrutura: acesso ao MongoDB

API: camada que expõe endpoints REST

Próximos passos
Implementar validações e tratamento de erros

Criar endpoints adicionais para consulta, atualização e exclusão

Adicionar autenticação e autorização

