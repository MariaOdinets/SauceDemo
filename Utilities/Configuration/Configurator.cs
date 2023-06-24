using Microsoft.Extensions.Configuration;
using SauceDemo.Models;
using System.Reflection;

namespace SauceDemo.Utilities.Configuration
{
    public static class Configurator
    {
        private static readonly Lazy<IConfiguration> configuration;
        public static IConfiguration Configuration => configuration.Value;

        static Configurator()
        {
            configuration = new Lazy<IConfiguration>(BuildConfiguration);
        }

        private static IConfiguration BuildConfiguration()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath ?? throw new InvalidOperationException())
                .AddJsonFile("appsettings.json"); ;

            return builder.Build();
        }

        public static AppSettings AppSettings
        {
            get
            {
                var appSettings = new AppSettings();
                var child = Configuration.GetSection("AppSettings");

                appSettings.URL = child["URL"];

                return appSettings;
            }
        }

        public static List<User?> Users
        {
            get
            {
                List<User?> users = new List<User?>();
                var child = Configuration.GetSection("Users");
                foreach (var section in child.GetChildren())
                {
                    var user = new User
                    {
                        Password = section["Password"],
                        Username = section["Username"],
                        UserType = section["UserType"]
                    };
                    users.Add(user);
                }
                return users;
            }
        }
        public static User? GetUserByUsername(string username) => Users.Find(x => x?.Username == username);
    }
}