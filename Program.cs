using System;
using System.Data.SqlClient;



string connectionString =@"Data Source=newMachine\SQLEXPRESS;Initial Catalog=guitarFriend;Integrated Security=False;User ID=myGuitarWork;Password=Warrior2892$$";

using(SqlConnection connection = new SqlConnection(connectionString))
{
    try
    {
        connection.Open();
        Console.WriteLine("Connection is green");

        //i belive we put sql queries here
    }
    catch(SqlException e)
    {
        Console.WriteLine("What went wrong: "+ e.Message);
    }

}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
