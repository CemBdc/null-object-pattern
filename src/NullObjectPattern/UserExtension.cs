using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public static class UserExtension
    {
        public static AbstractUser GetDefault(this AbstractUser user)
        {
            return user == null ? new NullUser() : user;
        }
    }
}
