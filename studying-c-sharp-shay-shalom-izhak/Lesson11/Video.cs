using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public class Video : Media, IPlayable, IStorable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing video...");
        }

        public void Save()
        {
            Console.WriteLine("Saving video...");
        }

        public void Load()
        {
            Console.WriteLine("Loading video...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Duration: {Duration} minutes");
        }
    }

}
