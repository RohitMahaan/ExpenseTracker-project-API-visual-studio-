using ExpenseTrackerAPI.Models;
using ExpenseTrackerAPI.Repositories.Interfaces;
using ExpenseTrackerAPI.Repositories;
using ExpenseTrackerAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add DbContext
builder.Services.AddDbContext<ExpenseTrackerDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));


// DI
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<ExpenseService>();

// Add services to the container.
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
 * skjdbkj
 * bfdlkbndfb
 * mnsdjvndf,
 * hbfdhbdhbh
 * bngfngfbn bg
 * bnfbgb fgb dthwsrgy rh trhbrtgd fb
 * gtrhbflmkn bjklkbgrt brb
 * jkvlbklnenrov  vnvrnno kvnkllklkvv vlk
 * vkjbjkkjnvnendv
 * blf doblkfdblkfdv
 * skjsdv dddddddddd sasasasasasasasasasa eeeeeeeeeeef  sdddddddddf  asfa fffffffffffffffffff adfdfdfdfdfdfdfdfawrdf
*/