using SauceDemo.Utilities.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Models
{
    public static class UserBuilder
    {
        public static User StandartUser
        {
            get
            {
                var user = Configurator.GetUserByUsername("standard_user");

                return new User
                {
                    Username = user.Username,
                    Password = user.Password
                };
            }
        } 

        public static User LockedOutUser
        {
            get
            {
                var user = Configurator.GetUserByUsername("locked_out_user");

                return new User
                {
                    Username = user.Username,
                    Password = user.Password
                };
            }
        }

        public static User ProblemUser
        {
            get
            {
                var user = Configurator.GetUserByUsername("problem_user");

                return new User
                {
                    Username = user.Username,
                    Password = user.Password
                };
            }
        }
    }
}