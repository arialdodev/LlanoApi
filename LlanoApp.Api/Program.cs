using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using LlanoApp.Infrastructure;
using LlanoApp.Infrastructure.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

# region registro mediator
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});
#endregion

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

# region inyeccion de dependencia
builder.Services.AddScoped<IRepository<ResourceTypes>, ResourceTypesRepository>();
builder.Services.AddScoped<IRepository<Resource>, ResourceRepository>();
# endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
