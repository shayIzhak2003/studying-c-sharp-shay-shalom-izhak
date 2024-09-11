using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Facade.Facade_Class
{
    public class HomeTheaterFacade
    {
        private DVDPlayer dvdPlayer;
        private Projector projector;
        private SoundSystem soundSystem;
        private Lights lights;

        public HomeTheaterFacade(DVDPlayer dvd, Projector proj, SoundSystem sound, Lights light)
        {
            this.dvdPlayer = dvd;
            this.projector = proj;
            this.soundSystem = sound;
            this.lights = light;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            lights.Dim(10);
            projector.On();
            projector.SetInput("DVD");
            soundSystem.On();
            soundSystem.SetVolume(20);
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater...");
            dvdPlayer.Off();
            soundSystem.Off();
            projector.Off();
            lights.On();
        }
    }

}
