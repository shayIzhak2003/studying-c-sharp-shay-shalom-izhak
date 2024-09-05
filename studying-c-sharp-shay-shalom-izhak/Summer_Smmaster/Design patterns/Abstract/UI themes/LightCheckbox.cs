using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Abstract.UI_themes
{
    // Concrete product - Light Checkbox
    public class LightCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render Light Checkbox");
        }
    }
}
