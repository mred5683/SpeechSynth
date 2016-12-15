using System;
using System.IO;
using System.Diagnostics;
using System.Speech.Synthesis;
using static System.Console;

namespace SpeechSynth {

  internal class Program {
    public static void Main() {
      Questions();
      Menu();
    }

    public static void Menu() {
      WriteLine("What would you like to do?");
      WriteLine("(1) - Review text written to file");
      WriteLine("(2) - Hear text written to file");

      var choice = int.Parse(ReadLine());

      switch (choice) {
        case 1:
          Process.Start(@"C:\TFTF\SpeechSynth.txt");
          WriteLine("Is this correct (Y/N)?");
          var answer = ReadLine();
          if (!answer.Equals("y", StringComparison.OrdinalIgnoreCase)) {
            WriteLine("Lets try again\n");
            WriteLine("press any key to continue...");
            ReadKey();
            Main();
          }
          ReadKey();
          break;
        case 2:
          ReadAndSpeak();
          break;
      }
    }

    public static void Questions() {
      WriteLine("What is your name?");
      var name = ReadLine();
      WriteLine("How old are you?");
      var age = int.Parse(ReadLine());
      WriteLine("What city were you born in?");
      var cityOfBirth = ReadLine();

      var person = new Person(name, age, cityOfBirth);

      GetPropertiesAndWriteToFile(person);
    }

    public static void GetPropertiesAndWriteToFile(Person person) {

      File.WriteAllText(@"C:\TFTF\SpeechSynth.txt", string.Empty);

      var writeFile = new StreamWriter(@"C:\TFTF\SpeechSynth.txt");
      var personInfo = person.GetType().GetProperties();

      foreach (var item in personInfo) {
        writeFile.WriteLine("My {0} is", item.Name);
        writeFile.WriteLine(item.GetValue(person));
      }

      writeFile.Close();
    }

    public static void ReadAndSpeak() {
      var streamReader = new StreamReader(@"C:\TFTF\SpeechSynth.txt");

      var readFileContents = streamReader.ReadToEndAsync();
      var synth = new SpeechSynthesizer();

      synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
      synth.Speak(readFileContents.Result);
    }
  }
}