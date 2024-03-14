
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;

using Microsoft.Extensions.Configuration;
using Backend.Data.Models;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false)
    .Build();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MembershipcardContext>(options =>
    options.UseSqlServer(config.GetConnectionString("db1")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.OperationFilter<AutorizacijaSwaggerHeader>();
});
//builder.Services.AddTransient<MyAuthService>();
//builder.Services.AddTransient<MyEmailLog>();
//builder.Services.AddTransient<MyEmailSender>();
//builder.Services.AddTransient<MyActionLog>();
builder.Services.AddHttpContextAccessor();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())//ovaj if iskljucuje swagger nakon deploya na app.fit.ba
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.Urls.Add("http://0.0.0.0:3000");

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors(
    options => options
        .SetIsOriginAllowed(x => _ = true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
); //This needs to set everything allowed


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
