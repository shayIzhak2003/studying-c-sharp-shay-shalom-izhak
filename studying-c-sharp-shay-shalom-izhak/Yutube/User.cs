using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Yutube
{
    public class User
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }

        public void UploadVideo(VideoService videoService, string title, string description, string filePath)
        {
            videoService.AddVideo(new Video(title, description, filePath));
        }

        public void ViewVideos(VideoService videoService)
        {
            videoService.ListVideos();
        }
    }

}
