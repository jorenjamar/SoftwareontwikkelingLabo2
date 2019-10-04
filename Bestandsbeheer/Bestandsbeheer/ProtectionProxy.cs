using System;
using System.Collections.Generic;
using System.Text;

namespace Bestandsbeheer
{
    public class ProtectionProxy : IFile
    {
        private CacheProxy cacheProxy;
        private List<User> users = new List<User>();
        private User user;
        public ProtectionProxy()
        {
            users.Add(new User("admin", "admin", true));
            users.Add(new User("user", "", false));
            while (user == null) LogIn();
        }

        public void RequestFile(string fileName)
        {
            if(user == null)
            {
                Console.WriteLine("you must login first");
                while (user == null) LogIn();
            }
            if(cacheProxy == null)
            {
                cacheProxy = new CacheProxy();
            }
            cacheProxy.RequestFile(fileName);
        }

        private void LogIn()
        {
            Console.Write("username: ");
            string username = Console.ReadLine();
            if (users.Exists(x => x.name == username))
            {
                if(users.Find(x => x.name == username).admin)
                {
                    Console.Write("password: ");
                    string password = Console.ReadLine();
                    if (users.Find(x => x.name == username).password == password)
                    {
                        user = users.Find(x => x.name == username);
                    }
                    else Console.WriteLine("ERROR: password incorrect");
                }
                else
                {
                    user = users.Find(x => x.name == username);
                }
            }
            else
            {
                Console.WriteLine("ERROR: user name doesn't excist");
            }
        }
    }

    public class User
    {
        public string name { get; }
        public string password { get; }
        public bool admin { get; }

        public User(string name, string password, bool admin) {
            this.name = name;
            this.password = password;
            this.admin = admin;
        }
    
    }
}
