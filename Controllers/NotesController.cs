using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myGuitarFriend.Models;
using System.Media;
using System.Runtime.InteropServices;

// [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, Charset = CharSet.Ansi, SetLastError = true)]
// private static extern int myfunc(string a, string b, int c, int d);

namespace myGuitarFriend.Controllers;

public class NotesController: Controller
{
    private readonly ILogger<NotesController> _logger;

    public NotesController(ILogger<NotesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Test()
    {
      return Content("This button works c# and this language is very simple ");
    }
}