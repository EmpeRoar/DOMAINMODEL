using Commons.Entities.UserAggregate;
using Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionVendor.DomainModel.Entities.UserAggregate
{
    public class SolutionVendorUser : User
    {
        public SolutionVendorUser(IUserType userType) : base(userType)
        {

        }
    }
}
