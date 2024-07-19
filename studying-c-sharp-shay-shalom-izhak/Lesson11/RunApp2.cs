using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public class RunApp2
    {
       public static void DemoMain()
        {
            
            IPlayable[] playables = new IPlayable[]
            {
            new Video { Title = "Movie", Duration = 120 },
            new Video { Title = "Clip", Duration = 5 }
            };

            foreach (var playable in playables)
            {
                playable.Play();
            }

            PlayMedia(new Video { Title = "Documentary", Duration = 60 });

            
            Television tv = new Television();
            Painting painting = new Painting();

            Wall wall = new Wall();
            wall.AddHangable(tv);
            wall.AddHangable(painting);

            wall.DisplayHangables();
        }

        public static void PlayMedia(IPlayable playable)
        {
            playable.Play();
            playable.Pause();   
        }
    }
}
