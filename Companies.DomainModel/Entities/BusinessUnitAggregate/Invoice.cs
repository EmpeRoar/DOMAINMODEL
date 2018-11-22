using Commons.Entities;
using Companies.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.BusinessUnitAggregate
{
    public class Invoice : BaseEntity
    {
        public Invoice()
        {

        }

        public int BusinessUnitId { get; private set; }
        public IInvoiceStatus InvoiceStatus { get; private set; }
    }
}
