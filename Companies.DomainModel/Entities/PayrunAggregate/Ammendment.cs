using Commons.Entities;
using Companies.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.PayrunAggregate
{
    public class Ammendment : BaseEntity
    {
        public Ammendment(IAmmendmentType ammendmentType)
        {
            AmmendmentType = ammendmentType;
        }

        public IAmmendmentType AmmendmentType { get; private set; }


    }
}
