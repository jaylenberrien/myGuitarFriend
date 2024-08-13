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

  private WaveInEvent waveIn;
  private WaveFileWriter writer;

  public void startRec()
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
  }

  public void endRec()
  {
    var waveIn = new WaveInEvent();
    waveIn.StopRecording();

    waveIn.RecordingStopped += (s, a) =>
    {
      writer?.Dispose();
      writer = null;
      waveIn.Dispose();
      // f.showDialog();
    };
  }
 
}


//the functions used to be under the return type -> IActionResult; We'll see if it makes a difference 


