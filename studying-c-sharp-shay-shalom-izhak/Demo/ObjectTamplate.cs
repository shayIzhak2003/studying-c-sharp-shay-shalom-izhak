using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Demo
{
    
     public class ObjectTamplate
     {
        //properties - שדות/תכונות
        public int intProperty = 10;

        public string stringProperty = "some string";

        public bool boolProperty = false;

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }
        public void ChangeString(string value)
        {
            stringProperty = value;
        }
        public void ChangeInt(int value)
        {
            intProperty = value;
        }



    }
    public class Chair 
    {
        public Chair() { }
        public Chair(string color, int height , bool isWood)
        {
           this.color = color;
           this.height = height;
           this.isWood = isWood;
        }

        public string color = "white";
        public int height = 46;
        public bool isWood = false;
        public void DisplayProps()
        {
            Console.WriteLine("chair = [color = {0}, height = {1}, isWood = {2}]", color, height, isWood);
        }

    }
    public class Room 
    {
        public string type = "bathroom";
        public int sqm = 10;
        public bool hasWindows = true;
        public Chair chair = new Chair();

        public void DisplayProps()
        {
            Console.WriteLine("room = [type = {0}] ",type );
            chair.DisplayProps();
        }
    }
    public class Home 
    {
        public Room[] rooms = new Room[3];
        public Home()
        {
            rooms[0] = new Room();
        }
        public Home(string type)
        {
            rooms[0] = new Room();
            rooms[0].type = type;
        }
    }


    public class TestBasicObject
    {

        public static void Demo()
        {
            ObjectTamplate template1 = new ObjectTamplate();
            ObjectTamplate template3 = new ObjectTamplate();


            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.boolProperty = true;
            template1.stringProperty = "another string";
            template1.intProperty = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);


            template3.boolProperty = true;
            template3.stringProperty = "hello";
            template3.intProperty = 250;
            Console.WriteLine("Template 3 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template3.intProperty, template3.stringProperty, template3.boolProperty);
            ObjectTamplate template2 = new ObjectTamplate();

            template2.ChangeString("third string");
            template2.ChangeInt(2000);
            
            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);

            Chair c1 = new Chair();
            c1.DisplayProps();
            c1.color = "Black";
            c1.DisplayProps();

            Home home = new Home();
            home.rooms[0].DisplayProps();

            Home home2 = new Home("warhouse");
            home2.rooms[0].DisplayProps();
            Console.WriteLine("======");
            Chair c2 = new Chair("orange", 50, false);
            c2.DisplayProps();// invocation
        }

    }
}
