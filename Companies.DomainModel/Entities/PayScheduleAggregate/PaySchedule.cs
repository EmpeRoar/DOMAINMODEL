using Commons.Entities;
using Commons.Interfaces;
using Companies.DomainModel.Interfaces;
using Companies.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.Entities.PayScheduleAggregate
{
    public class PaySchedule : BaseEntity, IAggregateRoot
    {
        public PaySchedule()
        {

        }

        public int CompanyId { get; private set; }
        public IPayrollModel PayrollModel { get; private set; }
        
    }
}
