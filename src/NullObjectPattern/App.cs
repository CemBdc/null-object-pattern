using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class App
    {
        public App()
        {
            var userService = new UserService();
            var user = userService.GetUserById(1);

            Console.WriteLine($"User FullName: {user.GetFullName()}");
        }
    }
}
