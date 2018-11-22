using Commons.Entities;
using Commons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollServiceProvider.DomainModel.Entities.InvoiceAggregate
{
    public class Invoice : BaseEntity, IAggregateRoot
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public IReadOnlyCollection<Employee> Employees => _employees.AsReadOnly();

        public Invoice()
        {

        }

        public void AddEmployee(int id)
        {
            if (!Employees.Any(i => i.Id == id))
            {
                // Todo: add properties here...
                _employees.Add(new Employee());
                return;
            }
        }
    }
}
