using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.OOP_DB_App.Common
{
    public class ChangeBgAndFontColor
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("Choose a background color:");
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine($"{(int)color} - {color}");
            }

            if (int.TryParse(Console.ReadLine(), out int bgColorIndex) &&
                Enum.IsDefined(typeof(ConsoleColor), bgColorIndex))
            {
                Console.BackgroundColor = (ConsoleColor)bgColorIndex;
                Console.Clear(); // Apply the new background color to the whole console
                Console.WriteLine($"Background color changed to {Console.BackgroundColor}");
            }
            else
            {
                Console.WriteLine("Invalid color selection.");
            }
        }

        public void ChangeFontColor()
        {
            Console.WriteLine("Choose a font color:");
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine($"{(int)color} - {color}");
            }

            if (int.TryParse(Console.ReadLine(), out int fontColorIndex) &&
                Enum.IsDefined(typeof(ConsoleColor), fontColorIndex))
            {
                Console.ForegroundColor = (ConsoleColor)fontColorIndex;
                Console.WriteLine($"Font color changed to {Console.ForegroundColor}");
            }
            else
            {
                Console.WriteLine("Invalid color selection.");
            }
        }
    }
    public class RunApp
    {
        public static void Run()
        {

            MainObjectRun app = new MainObjectRun();
            app.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
