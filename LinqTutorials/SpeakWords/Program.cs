using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SpeakWords
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -3;     // -10...10

            // Synchronous
            synthesizer.Speak("Break for Lunch");

            // Synchronous
            synthesizer.Speak("Hello Dhruv! Please Decrease The Volume");
        }
    }
}
