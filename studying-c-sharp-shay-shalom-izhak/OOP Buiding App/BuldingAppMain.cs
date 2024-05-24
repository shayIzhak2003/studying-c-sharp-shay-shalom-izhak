using studying_c_sharp_shay_shalom_izhak.Demo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.OOP_Buiding_App
{
    public class BuildingAppMain
    {
        public int BuildingNumber { get; set; }
        public int numOfFloors = 7;
        public Apartment[] numOfApartments = new Apartment[14];

        public void DisplayBuildingProps()
        {
            Console.WriteLine($"BuildingNumber = {BuildingNumber}, numOfFloors = {numOfFloors}, numOfApartments = {numOfApartments.Length}");
        }
    }

    public class Apartment
    {
        public int sqm = 300;
        public int numOfRooms = 6;
        public double Price = 210000;
        public string OwnerName { get; set; }

        public void DisplayApartmentProps()
        {
            Console.WriteLine($"sqm = {sqm}, Price = ${Math.Round(Price)}, numOfRooms = {numOfRooms}, OwnerName = {OwnerName}");
        }
    }

    public class Rooms
    {
        public int roomSize = 50;

        public void DisplayRoomProps()
        {
            Console.WriteLine($"roomSize = {roomSize}");
        }
    }

    public class TestBasicObject2
    {
        public static void Demo()
        {
            Random random = new Random();
            string[] names = { "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy", "Kevin", "Laura", "Mallory", "Niaj" };

            BuildingAppMain b1 = new BuildingAppMain { BuildingNumber = 1 };
            BuildingAppMain b2 = new BuildingAppMain { BuildingNumber = 2 };

            InitializeApartments(b1, random, names);
            InitializeApartments(b2, random, names);

            b1.DisplayBuildingProps();
            Console.WriteLine();
            foreach (var apartment in b1.numOfApartments)
            {
                apartment.DisplayApartmentProps();
            }
            Console.WriteLine();

            b2.DisplayBuildingProps();

            Console.WriteLine();
            foreach (var apartment in b2.numOfApartments)
            {
                apartment.DisplayApartmentProps();
            }
        }

        private static void InitializeApartments(BuildingAppMain building, Random random, string[] names)
        {
            for (int i = 0; i < building.numOfApartments.Length; i++)
            {
                building.numOfApartments[i] = new Apartment
                {
                    sqm = random.Next(50, 401),
                    numOfRooms = random.Next(1, 10),
                    Price = random.NextDouble() * (500000 - 100000) + 100000,
                    OwnerName = names[random.Next(names.Length)]
                };
            }
        }
    }
}
