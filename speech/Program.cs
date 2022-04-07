using System;
using System.Collections.Generic;
using System.Text;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace speech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer sp = new SpeechSynthesizer();
                    // Initialize a new instance of the SpeechSynthesizer.  
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                synth.Volume = 70;
                synth.Rate = -1;
                synth.Speak("Ticket number 709, please proceed to counter number 5");

            }
            
        }
    }
}
