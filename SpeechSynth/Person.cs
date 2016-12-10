using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSynth {
  public class Person {
    string Name { get; set; }
    string Gender { get; set; }
    DateTime DOB {get; set; }

    public Person(string name, string gender, DateTime dob) {
      Name = name;
      Gender = gender;
      DOB = dob;
    }
  }
}
