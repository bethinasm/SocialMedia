using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOppgave
{
    internal class User
    {
        public string Name { get; set; }
        public int Birthday { get; set; }
        public string Bio {  get; set; }

        public List<User> Friends { get; private set; } = new List<User>();

        public User(string name, int birthday, string bio)
        {
            Name = name;
            Birthday = birthday;
            Bio = bio;
        }

        public void AddFriend(User user)
        {
            if (!Friends.Contains(user))
            {
                Friends.Add(user);
                Console.WriteLine($"{user.Name} has been added as a friend");
            }
            else 
            {
                Console.WriteLine($"{user.Name} is already your friend");
            }
        }

        public void RemoveFriend(User user)
        {
            Console.WriteLine($"{user.Name} has been removed from your friends");
        }

        public void PrintFriendList()
        {
            var friendIndex = 1;
            if (Friends.Any())
            {
                Console.WriteLine("Your friends:\n");
                foreach (var friend in Friends)
                {
                    Console.WriteLine($"{friendIndex} {friend.Name}");
                    friendIndex++;
                }
            }
            else
            {
                Console.WriteLine("You have no friends yet");
            }
        }

        public void PrintProfile()
        {
            Console.WriteLine($"{Name}\nBirthday: {Birthday}\nBio: {Bio}\n");
        }
    }
}
