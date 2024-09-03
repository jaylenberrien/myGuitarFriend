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
        return Content("This is so annoying");
    }
}



