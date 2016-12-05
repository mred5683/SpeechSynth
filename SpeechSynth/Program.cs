using System;
using System.Data;
using static System.Console;
using System.Speech.Synthesis;

namespace SpeechSynth {

  class Program {
    static void Main(string[] args) {
      #region

      ////trying to understand the SpeechSynthesizer Class and methods
      

      var userInput = string.Empty;
      var synth = new SpeechSynthesizer();
      while (userInput != "exit") {
        WriteLine("what would you like me to say?      ---'exit' to quit---");
        WriteLine("");
        userInput = ReadLine();

        synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
        synth.Speak(userInput);

      }

      #endregion

      //example code pulled down from tutorial

      #region

      //// Initialize a new instance of the SpeechSynthesizer.
      //using (var synth = new SpeechSynthesizer()) {

      //  // Output information about all of the installed voices. 
      //  Console.WriteLine("Installed voices -");
      //  foreach (var voice in synth.GetInstalledVoices()) {
      //    var info = voice.VoiceInfo;
      //    var AudioFormats = "";
      //    foreach (var fmt in info.SupportedAudioFormats)
      //      AudioFormats += string.Format("{0}\n",
      //        fmt.EncodingFormat);

      //    Console.WriteLine(" Name:          " + info.Name);
      //    Console.WriteLine(" Culture:       " + info.Culture);
      //    Console.WriteLine(" Age:           " + info.Age);
      //    Console.WriteLine(" Gender:        " + info.Gender);
      //    Console.WriteLine(" Description:   " + info.Description);
      //    Console.WriteLine(" ID:            " + info.Id);
      //    Console.WriteLine(" Enabled:       " + voice.Enabled);
      //    if (info.SupportedAudioFormats.Count != 0) Console.WriteLine(" Audio formats: " + AudioFormats);
      //    else Console.WriteLine(" No supported audio formats found");

      //    var AdditionalInfo = "";
      //    foreach (var key in info.AdditionalInfo.Keys) AdditionalInfo += string.Format("  {0}: {1}\n", key, info.AdditionalInfo[key]);

      //    Console.WriteLine(" Additional Info - " + AdditionalInfo);
      //    Console.WriteLine();
      //  }
      //}

      //Console.WriteLine("Press any key to exit...");
      //Console.ReadKey();

      #endregion
    }
  }
}