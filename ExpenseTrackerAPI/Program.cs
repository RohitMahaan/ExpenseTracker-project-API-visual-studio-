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
 * bvdf,bkdf vjdfb kb vk
 * mnjhfjkdvkjkjvjk kfkjdbjkfkj
 * kljvfd vfkjvkj jkfvjkv
 * lkbdf bklbv
 * b fkbfbnfklbn nbkdn kldv nkfd bf b b jfkb fdb
 *  kfjdbjkfkljknklfd fvfd
 *  t hb pbf
 *  dfoigv ;lj lfhvil 
 *  fkjdskgk nblkdfnkjfhbdrldrsiodndfjklnvb;oddhbb
 *  goiiojr; hszdfhbhth ior heh fdklbnfd
 *  fdfkjnbkjfdnbklnlkd; jrghbdb nb dbbvohoigbsf dbfjbn
 *  lkrhiorepohvhjretn 54uofd f
 *  dfgfd kfdb fd biohgrklg9509uy0944t4u4y94u4t4 hynlkre  ;lyt 
 *  t 4yy 5kjbyjuiy 
 *   fgng
 *   jhnrtfgjnfgnfgnf
 *   gm 
 *   n ngfnmlkfgdk;l kj bn
 *   fgngfnb lgffg
 *   gfnfg ygh fg
 *   jnfgn
 *   j
*/