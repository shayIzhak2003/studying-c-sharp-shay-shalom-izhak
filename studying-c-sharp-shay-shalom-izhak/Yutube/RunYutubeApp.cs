using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Yutube
{
    public class RunYutubeApp
    {
       public static void DemoMain()
        {
            var videoService = new VideoService();
            var user = new User("JohnDoe");

            while (true)
            {
                Console.WriteLine("1. Upload Video");
                Console.WriteLine("2. View Videos");
                Console.WriteLine("3. Play Video");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter video title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter video description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter video file path: ");
                        string filePath = Console.ReadLine();
                        user.UploadVideo(videoService, title, description, filePath);
                        break;
                    case "2":
                        user.ViewVideos(videoService);
                        break;
                    case "3":
                        Console.Write("Enter video title to play: ");
                        string videoTitle = Console.ReadLine();
                        videoService.PlayVideo(videoTitle);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
