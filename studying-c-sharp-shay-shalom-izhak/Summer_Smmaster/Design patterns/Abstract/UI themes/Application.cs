using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Abstract.UI_themes
{
    public class Application
    {
        private IButton _button;
        private ICheckbox _checkbox;

        // Constructor that accepts a factory
        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        // Method to render the UI components
        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
    public class RunApplication
    {
        public static void DemoMain()
        {
            // Choose the factory dynamically (Light or Dark theme)
            IUIFactory factory;

            Console.WriteLine("Enter 'light' or 'dark' to choose a theme:");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "light")
            {
                factory = new LightThemeFactory();
            }
            else
            {
                factory = new DarkThemeFactory();
            }

            // Create the application with the chosen factory
            Application app = new Application(factory);
            app.RenderUI();
        }
    }

}
