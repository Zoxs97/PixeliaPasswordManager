using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PixeliaPasswordManager
{
    public class UserDataManager
    {
        private const string UserDataFile = "Data/UserData/users.json";

        public class UserData
        {
            public string Username { get; set; }
            public string MasterPasswordHash { get; set; }
        }

        /// <summary>
        /// Saves the user
        /// </summary>
        /// <param name="user"></param>
        /// 
        public static void SaveUser(User user)
        {
            List<User> users = new List<User>();

            // Load existing user data (if any)
            if (File.Exists(UserDataFile))
            {
                string json = File.ReadAllText(UserDataFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            // Add the new user
            users.Add(user);

            // Serialize the updated user list and save it to the JSON file
            string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(UserDataFile, updatedJson);
        }

        /// <summary>
        /// loads the user
        /// </summary>
        /// <returns></returns>
        private static List<UserData> LoadUsers()
        {
            List<UserData> users = new List<UserData>();

            if (File.Exists(UserDataFile))
            {
                string json = File.ReadAllText(UserDataFile);
                users = JsonConvert.DeserializeObject<List<UserData>>(json);
            }

            return users;
        }

        public static User GetUserByUsername(string username)
        {
            // Load existing user data from the JSON file
            List<UserData> users = LoadUsers();

            // Find the user by username
            UserData userData = users.Find(user => user.Username == username);

            if (userData != null)
            {
                // Create a User object and set the username and hashed password
                User user = new User
                {
                    Username = userData.Username,
                    MasterPasswordHash = userData.MasterPasswordHash
                };

                return user;
            }
            else
            {
                // User not found
                return null;
            }
        }
    }
}
