using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSynth {
  public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string CityOfBirth {get; set; }

    public Person(string name, int age, string cityOfBirth) {
      Name = name;
      Age = age;
      CityOfBirth = cityOfBirth;
    }
  }
}
