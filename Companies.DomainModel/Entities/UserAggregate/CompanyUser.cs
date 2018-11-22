using Commons.Entities.UserAggregate;
using Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.UserAggregate
{
    public class CompanyUser : User
    {
        public CompanyUser(IUserType userType) : base(userType)
        {

        }

        
    }
}
