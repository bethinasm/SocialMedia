using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOppgave
{
    internal class User
    {
        public string Name;
        public int Birthday;
        public string Bio;
        public List<User> Friends { get; private set; } = new List<User>();
    }
}
