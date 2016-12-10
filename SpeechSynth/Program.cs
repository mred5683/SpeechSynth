using System;
using static System.Console;
using System.Speech.Synthesis;
using System.IO;

namespace SpeechSynth {

  class Program {
    static void Main(string[] args) {
      Menu();

      #region

      ////trying to understand the SpeechSynthesizer Class and methods

      //var userInput = string.Empty;
      //var synth = new SpeechSynthesizer();
      //while (userInput != "exit") {
      //  WriteLine("what would you like me to say?      ---'exit' to quit---");
      //  WriteLine("");
      //  userInput = ReadLine();

      //  synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
      //  synth.Speak(userInput);
      //}

      #endregion


    }

    static void Menu() {
      WriteLine("What is your name?");
      var name = ReadLine();
      WriteLine("What is your gender? (male/female)");
      var gender = ReadLine();
      WriteLine("What is your Date of Birth?");
      var dob = Convert.ToDateTime(ReadLine());

      var person = new Person(Convert.ToString(name), Convert.ToString(gender), Convert.ToDateTime(dob));
      var result = person.GetType().GetProperties();

      var readFile = new StreamReader(@"C:\TFTF\SpeechSynth.txt");

      var fileContents = readFile.ReadToEnd();

      readFile.Close();

      if (!fileContents.Equals(string.Empty)) {

      }

      File.WriteAllText(@"C:\TFTF\SpeechSynth.txt", string.Empty);

      var writeFile = new StreamWriter(@"C:\TFTF\SpeechSynth.txt");

      foreach (var item in result) {

      writeFile.WriteLine(item.Name);
    }

    writeFile.Close();

      ReadKey();
    }
  }
}