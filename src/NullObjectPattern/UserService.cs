using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
    public class UserService
    {
        private List<User> _users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Lorem",
                LastName = "Ipsum"
            },
            new User
            {
                Id = 2,
                FirstName = "Lorem2",
                LastName = "Ipsum2"
            }
        };

        public AbstractUser GetUserById(int id)
        {
            return _users.Where(p => p.Id == id).FirstOrDefault().GetDefault();
        }
    }
}
