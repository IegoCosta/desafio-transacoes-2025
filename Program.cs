using Aplicacao.Interfaces;
using Aplicacao.Servicos;
using Dominio.Repositorios;
using Infraestrutura.Contexto;
using Infraestrutura.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// ==========================
// Configuração de Serviços
// ==========================

// MongoDB
builder.Services.AddSingleton<MongoDbContexto>();

// Injeção de dependências (DI)
builder.Services.AddScoped<ITransacaoRepositorio, TransacaoRepositorio>();
builder.Services.AddScoped<ITransacaoServico, TransacaoServico>();

// Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ==========================
// Pipeline da aplicação
// ==========================

// Swagger + Custom CSS
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transacoes API v1");
    c.InjectStylesheet("/swagger-ui/custom.css"); // << usa o seu CSS personalizado
    c.DocumentTitle = "Documentação da API de Transações";
    c.HeadContent = "<style>body { font-family: Arial, sans-serif; }</style>";
});

// Segurança e roteamento
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
