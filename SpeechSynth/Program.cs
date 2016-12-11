using System;
using static System.Console;
using System.Speech.Synthesis;
using System.IO;

namespace SpeechSynth {

  internal class Program {
    private static void Main(string[] args) {
      Questions();
      ReadAndSpeak();
    }

    private static void Questions() {
      WriteLine("What is your name?");
      var name = ReadLine();
      WriteLine("Are you a man or woman?");
      var gender = ReadLine();
      WriteLine("What is your Date of Birth?");
      var dob = Convert.ToDateTime(ReadLine());

      var person = new Person(Convert.ToString(name), Convert.ToString(gender), Convert.ToDateTime(dob));

      GetPropertiesAndWriteToFile(person);
    }

    private static void GetPropertiesAndWriteToFile(Person person) {

      File.WriteAllText(@"C:\TFTF\SpeechSynth.txt", string.Empty);

      var writeFile = new StreamWriter(@"C:\TFTF\SpeechSynth.txt");
      var personInfo = person.GetType().GetProperties();

      foreach (var item in personInfo) {
        writeFile.WriteLine("My {0} is", (item.Name));
        writeFile.WriteLine(item.GetValue(person));
      }
      writeFile.Close();
    }

    private static void ReadAndSpeak() {
      var streamReader = new StreamReader(@"C:\TFTF\SpeechSynth.txt");

      var readFileContents = streamReader.ReadToEndAsync();
      var synth = new SpeechSynthesizer();

      synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
      synth.Speak(readFileContents.Result);
    }
  }
}