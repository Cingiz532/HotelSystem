using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.Dependency.autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  
/*builder.Services.AddSingleton<IProductManager, ProductManager>();
builder.Services.AddSingleton<IProductDal, Product Dal>();
builder.Services.AddSingleton<IAssistantManager, AssistantManager>();
builder.Services.AddSingleton<IAssistantDal, AssistantDal>();*/


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule<AutoFacBusinessModule>();
});
var app = builder.Build();//Bu ctrl shift B kimidir son ashamada bu yazilir

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
