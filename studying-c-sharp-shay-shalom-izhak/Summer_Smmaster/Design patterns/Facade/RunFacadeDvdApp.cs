using studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Facade.Facade_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Facade
{
    public class RunFacadeDvdApp
    {
        public static void DemoMain()
        {
            DVDPlayer dvdPlayer = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem soundSystem = new SoundSystem();
            Lights lights = new Lights();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, soundSystem, lights);

            homeTheater.WatchMovie("Inception");
            // Later
            homeTheater.EndMovie();
        }
    }
}
