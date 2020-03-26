using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class User: AbstractUser
    {
        public override string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
