var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(cors =>
{
    cors.AddPolicy("publicpolicy", settings =>
    {
        settings.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyOrigin();

    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("publicpolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
