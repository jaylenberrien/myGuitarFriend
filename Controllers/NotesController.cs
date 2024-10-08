using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myGuitarFriend.Models;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;



namespace myGuitarFriend.Controllers;

public class NotesController: Controller
{ 

  private readonly ILogger<NotesController> _logger;

  public NotesController(ILogger<NotesController> logger)
  {
    _logger = logger;
  }


// I said that both of these can be null because of 'problems' I kept getting back
// it didnt seem like it would be an issue if it was null at times but we will see
  private static WaveInEvent? waveIn;
  private static WaveFileWriter? writer;

  public IActionResult StartRec()
  {
    var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"Naudio");
    Directory.CreateDirectory(outputFolder);
    var outputFilePath = Path.Combine(outputFolder, "recorded.wav");

   waveIn = new WaveInEvent();
   writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
 
    
    waveIn.StartRecording();

   waveIn.DataAvailable += (s, a) =>
    {
      writer.Write(a.Buffer, 0, a.BytesRecorded);
    };

    waveIn.RecordingStopped += (s, a) =>
    {
      writer?.Dispose();
      writer = null;
      waveIn.Dispose();
    };

    return Content("Recording started");
  }

  public IActionResult EndRec()
  {

    // uncommenting this hasnt made it work before -> I dont know if that will give desired result
    // waveIn = new WaveInEvent();
    if (waveIn != null)
    {
      waveIn.StopRecording();
    }
    else
    {
      return Content("waveIn returned null");
    }
    

    return Content("Recording ended");
  }


  public IActionResult CreateNote()
  {
    return Content("note created");    
  }
}


//the functions used to be under the return type -> IActionResult; We'll see if it makes a difference 


