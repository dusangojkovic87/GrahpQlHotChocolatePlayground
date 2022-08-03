using GraphQlHotChocolateNetCore.DataContext;
using GraphQlHotChocolateNetCore.GraphQl.Mutation;
using GraphQlHotChocolateNetCore.GraphQl.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services.AddDbContext<AplicationDbContext>();
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

}



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
app.MapGraphQL("/graphql");

app.Run();
