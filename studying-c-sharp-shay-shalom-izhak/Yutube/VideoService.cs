using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Yutube
{
    public class VideoService
    {
        private List<Video> videos;

        public VideoService()
        {
            videos = new List<Video>();
        }

        public void AddVideo(Video video)
        {
            videos.Add(video);
            Console.WriteLine($"Video '{video.Title}' uploaded successfully!");
        }

        public void ListVideos()
        {
            if (videos.Count == 0)
            {
                Console.WriteLine("No videos available.");
                return;
            }

            Console.WriteLine("Available videos:");
            foreach (var video in videos)
            {
                Console.WriteLine($"- {video.Title} (Uploaded on {video.UploadDate})");
            }
        }

        public void PlayVideo(string title)
        {
            var video = videos.Find(v => v.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (video != null)
            {
                video.Play();
            }
            else
            {
                Console.WriteLine("Video not found.");
            }
        }
    }
}
