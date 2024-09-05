using System;
using System.Diagnostics;
using myGuitarFriend.Models;
using Microsoft.AspNetCore.Mvc;

namespace myGuitarFriend.Controllers;

public class AccountController:Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }


    public IActionResult Register()
    {     
        Console.WriteLine("see if it is working in dev tools");

        // var testRes = "This is so annoying";
        // string jsonData = JsonConvert.SerializeObject(testRes);
        // return Content(jsonData, "application/json");

        // var testRes = "This is so annoying";
        // return Json(testRes);

        return Content("this is from the controller");
    }
}



