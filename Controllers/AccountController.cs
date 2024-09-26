using System;
using System.Diagnostics;
using myGuitarFriend.Models;
// using Microsoft.AspNetCore.App;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Media;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace myGuitarFriend.Controllers;

public class AccountController:Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

//below we have how we want the body object to be handled, now we just have to create the fetch to send the body to this function, then we will be able to see if we got this part to work or not
    [HttpPost]
    public IActionResult Register([FromBody] AccountModel account)

    {     
        string connectionString = @"Data Source=newMachine\SQLEXPRESS,49172;Initial Catalog=guitarFriend;Integrated Security=False;User ID=myGuitarWork;Password=Warrior2892$$";
        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            if (account == null)
            {
                return BadRequest("No data inputted");
            }

            try
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand($"insert into dbo.user values({account.username},{account.password})", connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine($"{account.username} has been registered");
                    connection.Close();
                    return Ok(new {message = "Data was saved to db"});
                    
                }
                
            }

            catch(SqlException e)
            {
                Console.WriteLine("Register error" + e);
            }

        }
        


        return Content("Attempted to register user", "application/json");
    }

    
}



