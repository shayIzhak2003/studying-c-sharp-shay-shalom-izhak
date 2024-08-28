using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Singleton
{
    // User class representing a user
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }

    // Singleton class for managing users
    public class UserManager
    {
        private static UserManager _instance;
        private static readonly object _lock = new object();
        private List<User> _users;

        // Private constructor to prevent instantiation
        private UserManager()
        {
            _users = new List<User>();
        }

        // Public static method to get the single instance of the class
        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new UserManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to add a user
        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"User {user.Name} added.");
        }

        // Method to remove a user by ID
        public void RemoveUser(int userId)
        {
            User userToRemove = _users.Find(u => u.Id == userId);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
                Console.WriteLine($"User {userToRemove.Name} removed.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        // Method to list all users
        public void ListUsers()
        {
            if (_users.Count == 0)
            {
                Console.WriteLine("No users found.");
            }
            else
            {
                Console.WriteLine("List of users:");
                foreach (var user in _users)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }

    public class RunUserManager 
    {
        public static void DemoMain()
        {
            // Get the singleton instance of UserManager
            UserManager userManager = UserManager.Instance;

            // Add users
            userManager.AddUser(new User(1, "John Doe"));
            userManager.AddUser(new User(2, "Jane Smith"));
            userManager.AddUser(new User(3, "Emily Johnson"));

            // List users
            userManager.ListUsers();

            // Remove a user
            userManager.RemoveUser(2);

            // List users again to confirm removal
            userManager.ListUsers();

            // Attempt to remove a non-existent user
            userManager.RemoveUser(99);
        }
    }
}
