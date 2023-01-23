using Axily.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Configure services
builder.Services.AddControllers()
       .Services.AddSwaggerGenerator()
       .AddServiceContainer()
       .ConfigureNpgsqlContext(builder.Configuration);

var app = builder.Build();

//Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapControllers();
app.Run();
