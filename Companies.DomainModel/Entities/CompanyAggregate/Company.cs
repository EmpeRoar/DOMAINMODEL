using Commons.Entities;
using Commons.Interfaces;
using Companies.DomainModel.Interfaces;
using Companies.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.CompanyAggregate
{
    public class Company : BaseEntity, IAggregateRoot
    {
        public Company(CompanyName name)
        {
            Name = name;
        }

        public CompanyName Name { get; private set; }
    }
}
