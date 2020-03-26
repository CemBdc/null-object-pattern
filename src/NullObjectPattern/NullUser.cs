using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class NullUser: AbstractUser
    {
        public override string GetFullName()
        {
            return "User is not available";
        }
    }
}
