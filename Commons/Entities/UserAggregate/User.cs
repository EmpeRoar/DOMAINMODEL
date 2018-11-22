using Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Entities.UserAggregate
{
    public class User : BaseEntity, IAggregateRoot
    {
        public User(IUserType userType)
        {
            UserType = userType;
        }

        public IUserType UserType { get; private set; }

    }
}
