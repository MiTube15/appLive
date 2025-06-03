
using APPLIVES.APPLICATION;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//registro de interfaces
builder.Services.AddScoped<APPLIVE_IIptvService, APPLIVE_IptvServices>();
builder.Services.AddScoped<APPLIVE_APPLICATION, APPLIVES_APPLICATION_ENLACES>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agrega esto para permitir cualquier origen temporalmente
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


var app = builder.Build();
// Usa la política CORS antes de los endpoints
app.UseCors("PermitirTodo");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
