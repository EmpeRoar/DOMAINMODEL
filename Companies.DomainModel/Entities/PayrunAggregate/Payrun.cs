using Commons.Entities;
using Commons.Interfaces;
using Companies.DomainModel.Entities.PayrunAggregate.AmmendmentTypes;
using Companies.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Companies.DomainModel.Entities.PayrunAggregate
{
    public class Payrun : BaseEntity, IAggregateRoot
    {

        private readonly List<Ammendment> _ammendments = new List<Ammendment>();


        public IReadOnlyCollection<Ammendment> Ammendments => _ammendments.AsReadOnly(); 
        public AttachedInvoice AttachedInvoice { get; private set; }
        
        public Payrun(IPayrunType payrunType)
        {
            PayrunType = payrunType;
        }

        public void AddAmmendment(int id)
        {
            if (!Ammendments.Any(i => i.Id == id))
            {
                // Todo: add properties here...
                _ammendments.Add(new Ammendment(new AddEmployeeAmmendment())); 
                return;
            }
        }
        
        public IPayrunType PayrunType { get; private set; }
    }
}
