using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Facade
{
    // DVD Player
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player is ON");
        public void Off() => Console.WriteLine("DVD Player is OFF");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    }

    // Projector
    public class Projector
    {
        public void On() => Console.WriteLine("Projector is ON");
        public void Off() => Console.WriteLine("Projector is OFF");
        public void SetInput(string input) => Console.WriteLine($"Projector input set to: {input}");
    }

    // Sound System
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System is ON");
        public void Off() => Console.WriteLine("Sound System is OFF");
        public void SetVolume(int volume) => Console.WriteLine($"Volume set to: {volume}");
    }

    // Lights
    public class Lights
    {
        public void Dim(int level) => Console.WriteLine($"Lights dimmed to: {level}%");
        public void On() => Console.WriteLine("Lights are ON");
    }

}
