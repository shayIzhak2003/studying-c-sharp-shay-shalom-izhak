using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Yutube
{
    public class Video
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }

        public Video(string title, string description, string filePath)
        {
            Title = title;
            Description = description;
            FilePath = filePath;
            UploadDate = DateTime.Now;
        }

        public void Play()
        {
            Console.WriteLine($"Playing video: {Title}");
            // Simulate playing video
            Console.WriteLine($"Video file path: {FilePath}");
        }
    }
}
