using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSynth {
  public class Person {
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday {get; set; }

    public Person(string name, string gender, DateTime birthday) {
      Name = name;
      Gender = gender;
      Birthday = birthday;
    }
  }
}
