using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myGuitarFriend.Models;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;



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


 private void MciErrorCheck(int result)
  {
    if(result != 0)
    {
      StringBuilder errorText = new StringBuilder(256);
      mciGetErrorString(result, errorText, errorText.Capacity);
      _logger.LogError($"MCI Error: {errorText}");
      throw new InvalidOperationException(errorText.ToString());
    }
  }

  [DllImport("winmm.dll", CharSet = CharSet.Ansi)]
  private static extern int mciGetErrorString(int errorCode, StringBuilder errorText, int errorTextSize);

  public IActionResult startRec()
  {
    int result = myfunc("open new Type waveaudio Alias recsound","",0,0);
    MciErrorCheck(result);
    result = myfunc("record recsound","",0,0);
    MciErrorCheck(result);
    return Content("recording started");
  }

  public IActionResult endRec()
  {

    // laptop version

    // myfunc("save recsound C:\\Users\\jayle\\OneDrive\\Desktop","",0,0);
    // myfunc("close recsound","",0,0);
    // return Content("recording ended");

    // Pc version

    //the line below is why there is an issue with it saving and ending (i have to clikc it more than once. even then it doesnt save)
    int result = myfunc(@"save recsound C:\Users\Jaylen Berrien\Desktop\test.wav","",0,0);
    MciErrorCheck(result);
    result = myfunc("close recsound","",0,0);
    MciErrorCheck(result);
    return Content("recording ended");
  }

 
}