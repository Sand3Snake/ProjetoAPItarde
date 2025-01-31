using Microsoft.EntityFrameworkCore;
using ProjetoAPItarde.ORM;
using ProjetoAPItarde.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Adicione o contexto do banco de dados
builder.Services.AddDbContext<BdEmpresaTardeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicione o repositório FuncionarioR
builder.Services.AddScoped<FuncionarioR>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
