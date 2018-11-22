using Commons.Entities;
using Commons.Interfaces;
using Companies.DomainModel.Interfaces;
using Companies.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.BusinessUnitAggregate
{
    public class BusinessUnit : BaseEntity, IAggregateRoot
    {
        public BusinessUnit(BusinessUnitName businessUnitName)
        {
            BusinessUnitName = businessUnitName;
        }

        public int CompanyId { get; private set; }
        public BusinessUnitName BusinessUnitName { get; private set; }

    }
}
