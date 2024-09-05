//using studying_c_sharp_shay_shalom_izhak.Yutube;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Singleton
//{
//    public class Car
//    {
//        public string licencePlate { get; set; }
//        public string brand { get; set; }
//        public double price { get; set; }
//        public Car(string licencePlate, string brand, double price)
//        {
//            this.brand = brand;
//            this.price = price;
//            this.licencePlate = licencePlate;
//        }
//    }
//    public class CarRenting
//    {
//        private static CarRenting _instance;
//        private static readonly object _lock = new object();
//        private List<Car> _cars;

//        Private constructor to prevent instantiation
//        private CarRenting()
//        {
//            _cars = new List<Car>();
//        }

//        Public static method to get the single instance of the class
//        public static CarRenting Instance
//        {
//            get
//            {
//                if (_instance == null)
//                {
//                    lock (_lock)
//                    {
//                        if (_instance == null)
//                        {
//                            _instance = new CarRenting();
//                        }
//                    }
//                }
//                return _instance;
//            }
//        }

//        public static void AddCar(Car car)
//        {
//            _cars.Add(car);
//            Console.WriteLine($"User {user.Name} added.");
//        }


//    }
//    public class RunCarRenting
//    {

//    }

//}
