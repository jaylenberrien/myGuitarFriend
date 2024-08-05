using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myGuitarFriend.Models;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;



namespace myGuitarFriend.Controllers;

public class NotesController: Controller
{ 

  [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int myfunc(string a, string b, int c, int d);


  private readonly ILogger<NotesController> _logger;

  public NotesController(ILogger<NotesController> logger)
  {
    _logger = logger;
  }

  public IActionResult startRec()
  {
    myfunc("open new Type waveaudio Alias recsound","",0,0);
    myfunc("record recsound","",0,0);
    return Content("recording started");
  }

  public IActionResult endRec()
  {

    // laptop version

    // myfunc("save recsound C:\\Users\\jayle\\OneDrive\\Desktop","",0,0);
    // myfunc("close recsound","",0,0);
    // return Content("recording ended");

    // Pc version

    myfunc(@"save recsound C:\Users\Jaylen Berrien\Desktop\test.wav","",0,0);
    myfunc("close recsound","",0,0);
    return Content("recording ended");
  }
}