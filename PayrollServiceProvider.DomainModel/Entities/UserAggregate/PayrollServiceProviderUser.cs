using Commons.Entities.UserAggregate;
using Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollServiceProvider.DomainModel.Entities.UserAggregate
{
    public class PayrollServiceProviderUser : User
    {
        public PayrollServiceProviderUser(IUserType userType) : base(userType)
        {

        }
        

    }
}
